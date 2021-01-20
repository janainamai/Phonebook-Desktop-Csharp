
namespace WindowsFormsApp1
{
    partial class frmApresentar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApresentar));
            this.btn_fechar = new System.Windows.Forms.Button();
            this.datagridview_resultados = new System.Windows.Forms.DataGridView();
            this.lbl_resultados = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_ver_tudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(154, 321);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(92, 32);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // datagridview_resultados
            // 
            this.datagridview_resultados.AllowUserToAddRows = false;
            this.datagridview_resultados.AllowUserToDeleteRows = false;
            this.datagridview_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_resultados.Location = new System.Drawing.Point(15, 13);
            this.datagridview_resultados.MultiSelect = false;
            this.datagridview_resultados.Name = "datagridview_resultados";
            this.datagridview_resultados.ReadOnly = true;
            this.datagridview_resultados.RowHeadersVisible = false;
            this.datagridview_resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_resultados.Size = new System.Drawing.Size(525, 289);
            this.datagridview_resultados.TabIndex = 0;
            this.datagridview_resultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_resultados_CellClick);
            // 
            // lbl_resultados
            // 
            this.lbl_resultados.Location = new System.Drawing.Point(26, 331);
            this.lbl_resultados.Name = "lbl_resultados";
            this.lbl_resultados.Size = new System.Drawing.Size(128, 13);
            this.lbl_resultados.TabIndex = 5;
            this.lbl_resultados.Text = "label1";
            this.lbl_resultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(448, 321);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(92, 32);
            this.btn_apagar.TabIndex = 1;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(350, 321);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(92, 32);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_ver_tudo
            // 
            this.btn_ver_tudo.Location = new System.Drawing.Point(252, 321);
            this.btn_ver_tudo.Name = "btn_ver_tudo";
            this.btn_ver_tudo.Size = new System.Drawing.Size(92, 32);
            this.btn_ver_tudo.TabIndex = 3;
            this.btn_ver_tudo.Text = "Ver tudo";
            this.btn_ver_tudo.UseVisualStyleBackColor = true;
            this.btn_ver_tudo.Click += new System.EventHandler(this.btn_ver_tudo_Click);
            // 
            // frmApresentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 365);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ver_tudo);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.lbl_resultados);
            this.Controls.Add(this.datagridview_resultados);
            this.Controls.Add(this.btn_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmApresentar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmApresentar";
            this.Load += new System.EventHandler(this.frmApresentar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_resultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridView datagridview_resultados;
        private System.Windows.Forms.Label lbl_resultados;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_ver_tudo;
    }
}