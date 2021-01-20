using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlServerCe;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmApresentar : Form
    {
        int id_contato;
        string item_pesquisa;
        public frmApresentar(string _item_pesquisa = "")
        {
            InitializeComponent();
            this.item_pesquisa = _item_pesquisa;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            //fecha o form
            this.Close();
        }

        private void frmApresentar_Load(object sender, EventArgs e)
        {
            ConstruirDataGV();
        }

        private void ConstruirDataGV()
        {
            //constri a tabela de registros

            //ligar à DB
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + vars.base_dados);
            ligacao.Open();

            string query = "SELECT * FROM contatos";
            if (item_pesquisa != "")
                query = "SELECT * FROM contatos WHERE nome LIKE @item OR telefone LIKE @item";

            SqlCeCommand comando = new SqlCeCommand();
            comando.Parameters.AddWithValue("@item", "%" + item_pesquisa + "%");
            comando.CommandText = query;
            comando.Connection = ligacao;
               

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            datagridview_resultados.DataSource = dados;
            ligacao.Dispose();

            //apresenta número registros foram encontrados
            lbl_resultados.Text = "Resultados: " + datagridview_resultados.Rows.Count;

            //esconder colunas : id_contato e atualizacao
            datagridview_resultados.Columns["id_contato"].Visible = false;
            datagridview_resultados.Columns["atualizacao"].Visible = false;

            //alterar as dimensões das colunas
            datagridview_resultados.Columns["nome"].Width = CalcularLargura(60);
            datagridview_resultados.Columns["telefone"].Width = CalcularLargura(40);

            //controla a disponibilidade dos comandos
            btn_apagar.Enabled = false;
            btn_editar.Enabled = false;
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            //apagar a linha selecionada
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + vars.base_dados);
            ligacao.Open();
            SqlCeCommand comando = new SqlCeCommand("DELETE FROM contatos WHERE id_contato = " + id_contato, ligacao);
            comando.ExecuteNonQuery();
            comando.Dispose();
            ligacao.Dispose();

            //reconstruir datagridview
            ConstruirDataGV();
        }

        private void datagridview_resultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_contato = Convert.ToInt16(datagridview_resultados.Rows[e.RowIndex].Cells["id_contato"].Value);
            btn_apagar.Enabled = true;
            btn_editar.Enabled = true;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //edita o registro selecionado
            frmAdicionarEditar f = new frmAdicionarEditar(id_contato);
            f.ShowDialog();

            //atualizar a datagridview
            ConstruirDataGV();
        }

        private void btn_ver_tudo_Click(object sender, EventArgs e)
        {
            //volta a apresentar todos os registros de contatos
            item_pesquisa = "";
            ConstruirDataGV();
        }

        private int CalcularLargura(int porcentagem)
        {
            int largura_datagview = datagridview_resultados.Width - 20;
            int resultado = (largura_datagview * porcentagem) / 100;
            return resultado;
        }
    }
}
/*
   
 (pixels)
 largura da datagview = 100
 
 
 */