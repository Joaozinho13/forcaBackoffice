namespace FORCA_BACKOFFICE
{
    partial class frmPalavra
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dgvPalavra = new System.Windows.Forms.DataGridView();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.lblDescCat = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDificuldade = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbDificuldade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalavra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(269, 104);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(188, 104);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(107, 104);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // dgvPalavra
            // 
            this.dgvPalavra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalavra.Location = new System.Drawing.Point(18, 141);
            this.dgvPalavra.Name = "dgvPalavra";
            this.dgvPalavra.RowHeadersVisible = false;
            this.dgvPalavra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPalavra.Size = new System.Drawing.Size(421, 189);
            this.dgvPalavra.TabIndex = 8;
            this.dgvPalavra.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalavra_RowEnter);
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(82, 6);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(354, 20);
            this.txtPalavra.TabIndex = 7;
            // 
            // lblDescCat
            // 
            this.lblDescCat.AutoSize = true;
            this.lblDescCat.Location = new System.Drawing.Point(13, 9);
            this.lblDescCat.Name = "lblDescCat";
            this.lblDescCat.Size = new System.Drawing.Size(46, 13);
            this.lblDescCat.TabIndex = 6;
            this.lblDescCat.Text = "Palavra:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(13, 38);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblDificuldade
            // 
            this.lblDificuldade.AutoSize = true;
            this.lblDificuldade.Location = new System.Drawing.Point(13, 67);
            this.lblDificuldade.Name = "lblDificuldade";
            this.lblDificuldade.Size = new System.Drawing.Size(63, 13);
            this.lblDificuldade.TabIndex = 14;
            this.lblDificuldade.Text = "Dificuldade:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(82, 35);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(354, 21);
            this.cbCategoria.TabIndex = 15;
            // 
            // cbDificuldade
            // 
            this.cbDificuldade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDificuldade.FormattingEnabled = true;
            this.cbDificuldade.Location = new System.Drawing.Point(82, 64);
            this.cbDificuldade.Name = "cbDificuldade";
            this.cbDificuldade.Size = new System.Drawing.Size(355, 21);
            this.cbDificuldade.TabIndex = 16;
            // 
            // frmPalavra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 342);
            this.Controls.Add(this.cbDificuldade);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblDificuldade);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvPalavra);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.lblDescCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPalavra";
            this.Text = "Cadastro -> Palavra";
            this.Load += new System.EventHandler(this.frmPalavra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalavra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView dgvPalavra;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Label lblDescCat;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDificuldade;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbDificuldade;
    }
}