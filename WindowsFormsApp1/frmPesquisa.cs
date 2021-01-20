using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPesquisa : Form
    {
        public string texto_pesquisa { get; set; }
        public bool cancelado { get; set; }

        public frmPesquisa()
        {
            InitializeComponent();
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {

        }

        private void tbn_pesquisar_Click(object sender, EventArgs e)
        {
            //executa a pesquisa, apenas se existe texto na txtbox
            if (txt_pesquisa.Text == "")
            { cancelado = true; }
            else
            { texto_pesquisa = txt_pesquisa.Text; }
            
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Close();
        }
    }
}
