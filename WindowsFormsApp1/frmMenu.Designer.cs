
namespace WindowsFormsApp1
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_ver_tudo = new System.Windows.Forms.Button();
            this.lbl_versao = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(147, 196);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(114, 44);
            this.btn_pesquisar.TabIndex = 2;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(93, 24);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(236, 45);
            this.lbl_titulo.TabIndex = 6;
            this.lbl_titulo.Text = "Agenda SQL";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(147, 296);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(114, 44);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(147, 146);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(114, 44);
            this.btn_adicionar.TabIndex = 1;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_ver_tudo
            // 
            this.btn_ver_tudo.Location = new System.Drawing.Point(147, 96);
            this.btn_ver_tudo.Name = "btn_ver_tudo";
            this.btn_ver_tudo.Size = new System.Drawing.Size(114, 44);
            this.btn_ver_tudo.TabIndex = 0;
            this.btn_ver_tudo.Text = "Visualizar tudo";
            this.btn_ver_tudo.UseVisualStyleBackColor = true;
            this.btn_ver_tudo.Click += new System.EventHandler(this.btn_ver_tudo_Click);
            // 
            // lbl_versao
            // 
            this.lbl_versao.Location = new System.Drawing.Point(161, 374);
            this.lbl_versao.Name = "lbl_versao";
            this.lbl_versao.Size = new System.Drawing.Size(100, 23);
            this.lbl_versao.TabIndex = 5;
            this.lbl_versao.Text = "versao";
            this.lbl_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(147, 246);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(114, 44);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Limpar agenda";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 431);
            this.ControlBox = false;
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_versao);
            this.Controls.Add(this.btn_ver_tudo);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_pesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_ver_tudo;
        private System.Windows.Forms.Label lbl_versao;
        private System.Windows.Forms.Button btn_reset;
    }
}

