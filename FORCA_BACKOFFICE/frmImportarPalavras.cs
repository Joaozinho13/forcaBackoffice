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
    public partial class frmImportarPalavras : Form
    {
        FORCAEntities forcaContext = new FORCAEntities();

        public frmImportarPalavras()
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
                        Palavra pal = new Palavra();

                        var dados = linha.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                        if (dados.Length == 3)
                        {
                            pal.Palavra1 = dados[0];
                            pal.IDCategoria = dados[1];
                            pal.IDDificuldade = dados[2];

                            forcaContext.Palavra.Add(pal);
                        }
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
