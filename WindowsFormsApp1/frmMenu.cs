using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlServerCe;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            lbl_versao.Text = vars.versao;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            //sair da aplicação
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarEditar f = new frmAdicionarEditar();
            f.ShowDialog();
        }

        private void btn_ver_tudo_Click(object sender, EventArgs e)
        {
            //apresentar todos os resultados
            frmApresentar f = new frmApresentar();
            f.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            //abre o quadro para pesquisar um contato
            frmPesquisa f = new frmPesquisa();
            f.ShowDialog();

            //executa a pesquisa se o quadro não foi cancelado
            if (f.cancelado == true)
            {
                f.Dispose();
                return; 
            }

            //caso for falso, executa a pesquisa
            frmApresentar ff = new frmApresentar(f.texto_pesquisa);
            ff.ShowDialog();

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //apagar todos os registros da db
            if(MessageBox.Show("ATENÇÂO: Deseja apagar todos os contatos da agenda?", "ATENÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            //apagar todos os registros
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + vars.base_dados);
            ligacao.Open();

            SqlCeCommand comando = new SqlCeCommand("DELETE FROM contatos", ligacao);
            comando.ExecuteNonQuery();
            comando.Dispose();
            ligacao.Dispose();

            MessageBox.Show("Contatos apagados com sucesso.");
        }
    }
}
