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
    public partial class frmAdicionarEditar : Form
    {
        bool editar;
        int id_contato;

        public frmAdicionarEditar(int _id_contacto = -1)
        {
            InitializeComponent();

            //definir se vou add ou editar registro
            id_contato = _id_contacto;
            editar = id_contato == -1 ? false : true;
        }

        private void frmAdicionarEditar_Load(object sender, EventArgs e)
        {
            //apresenta os dados do contato, se necessário
            if (editar == true)
                ApresentaContato();
        }

        private void ApresentaContato()
        {
            //apresenta o contato que vai ser editado
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + vars.base_dados);
            ligacao.Open();
            DataTable dados = new DataTable();
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM contatos WHERE id_contato = " + id_contato, ligacao);
            adaptador.Fill(dados);

            //colocar os dados nos textbox
            txt_nome.Text = dados.Rows[0]["nome"].ToString();
            txt_telefone.Text = dados.Rows[0]["telefone"].ToString();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + vars.base_dados);
            ligacao.Open();

            //grava novo registro ou edita registro existente

            #region verificações
            //verifica se os campos estão preenchidos
            if (txt_nome.Text == "" || txt_telefone.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
                return;
            }
            #endregion

            //-----------------------------
            #region NOVO CONTATO
            if (editar == false)
            {
                //buscar o id_contato disponível 
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT MAX(id_contato) AS maxid FROM contatos", ligacao);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                //verifica se o valor é nulo
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                    id_contato = 0;
                else
                id_contato = Convert.ToInt16(dados.Rows[0][0]) + 1;
                
                //gravar novo contato na DB
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = ligacao;

                //parametros
                comando.Parameters.AddWithValue("@id_contato", id_contato);
                comando.Parameters.AddWithValue("@nome", txt_nome.Text);
                comando.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                comando.Parameters.AddWithValue("@atualizacao", DateTime.Now);

                //verifica se já existe um contato com o mesmo nome e telefone
                adaptador = new SqlCeDataAdapter();
                dados = new DataTable();
                comando.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND telefone = @telefone";
                adaptador.SelectCommand = comando;
                adaptador.Fill(dados);

                if (dados.Rows.Count != 0)
                {
                    //já existe um registro com o mesmo nome e telefone
                    if (MessageBox.Show("Já existe um registro com este nome e telefone." + Environment.NewLine + " Deseja gravar mesmo assim?", "ATENÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }


                //texto da query
                comando.CommandText = "INSERT INTO contatos VALUES(@id_contato, @nome, @telefone, @atualizacao)";

                //texto da query

                comando.ExecuteNonQuery();
                comando.Dispose();
                ligacao.Dispose();

                MessageBox.Show("Contato adicionado com sucesso.");

                //limpa campos
                txt_nome.Clear();
                txt_telefone.Clear();
                txt_nome.Focus();

            }
            #endregion

            //-----------------------------
            #region EDITAR CONTATO
            else
            {
                //edita novo contato na DB
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = ligacao;

                //parametros
                comando.Parameters.AddWithValue("@id_contato", id_contato);
                comando.Parameters.AddWithValue("@nome", txt_nome.Text);
                comando.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                comando.Parameters.AddWithValue("@atualizacao", DateTime.Now);


                //verifica se existe registro com esse nome e id diferente
                DataTable dados = new DataTable();
                comando.CommandText = "SELECT* FROM contatos WHERE nome = @nome AND telefone<> @telefone";
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(dados);

                if (dados.Rows.Count != 0)
                {
                    //foi encontrado um registro com o mesmo nome
                    if (MessageBox.Show("Já existe um registro com este nome." + Environment.NewLine + " Deseja gravar mesmo assim?", "ATENÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }

                //editar o registro selecionado
                comando.CommandText = "UPDATE contatos SET nome = @nome, telefone = @telefone, atualizacao = @atualizacao WHERE id_contato = @id_contato";
                comando.ExecuteNonQuery();

                //fechar quadro
                this.Close();
            }
            #endregion
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
