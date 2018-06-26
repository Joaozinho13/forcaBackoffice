using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORCA_BACKOFFICE
{
    public partial class frmCadastro : Form
    {
        FORCAEntities forcaContext = new FORCAEntities();

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria frmCategoria = new frmCategoria();
            frmCategoria.ShowDialog();
        }

        private void palavraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forcaContext.Categoria.Any())
            {
                frmPalavra frmPalavra = new frmPalavra();
                frmPalavra.ShowDialog();
            }
            else
            {
                MessageBox.Show("Cadastre as categorias primeiramente!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();
        }


        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportarCategorias frmImportarCategorias = new frmImportarCategorias();
            frmImportarCategorias.ShowDialog();
        }

       

        private void palavrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportarPalavras frmPalavra = new frmImportarPalavras();
            frmPalavra.ShowDialog();
        }
    }
}
