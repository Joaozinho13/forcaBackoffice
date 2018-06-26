namespace FORCA_BACKOFFICE
{
    partial class frmImportarCategorias
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
            this.lblImportacao = new System.Windows.Forms.Label();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.opdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblImportacao
            // 
            this.lblImportacao.Location = new System.Drawing.Point(12, 9);
            this.lblImportacao.Name = "lblImportacao";
            this.lblImportacao.Size = new System.Drawing.Size(439, 142);
            this.lblImportacao.TabIndex = 0;
            this.lblImportacao.Text = "Selecione o arquivo para fazer a importação das categorias. O arquivo deve conter" +
    " uma categoria por linha. Espaços em branco no início ou no final da linha serão" +
    " ignorados.";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(15, 65);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(316, 20);
            this.txtArquivo.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(337, 63);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Procurar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Importar!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // opdArquivo
            // 
            this.opdArquivo.FileName = "openFileDialog1";
            // 
            // frmImportarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 153);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.lblImportacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportarCategorias";
            this.Text = "Importar -> Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImportacao;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog opdArquivo;
    }
}