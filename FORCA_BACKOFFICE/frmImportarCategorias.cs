using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORCA_BACKOFFICE
{
    public partial class frmImportarCategorias : Form
    {
        FORCAEntities forcaContext = new FORCAEntities();

        public frmImportarCategorias()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (opdArquivo.ShowDialog() == DialogResult.OK)
            {
                txtArquivo.Text = opdArquivo.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArquivo.Text))
            {
                MessageBox.Show("Selecione um arquivo para realizar a importação!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (File.Exists(txtArquivo.Text))
                {
                    var linhas = File.ReadAllLines(txtArquivo.Text);

                    foreach (var linha in linhas)
                    {
                        Categoria cat = new Categoria();
                        cat.Descricao = linha.Trim();
                        forcaContext.Categoria.Add(cat);
                    }

                    forcaContext.SaveChanges();

                    MessageBox.Show("Importação realizada com sucesso!", "Atenção!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("O arquivo indicado não existe!", "Atenção!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
