using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORCA_BACKOFFICE
{
    public partial class frmCategoria : Form
    {
        FORCAEntities forcaContext = new FORCAEntities();

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void PreencherGrid()
        {
            dgvCategoria.DataSource = (from cat in forcaContext.Categoria select new { ID = cat.Id, Categoria = cat.Descricao }).ToList();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Preencha o campo com a descrição da categoria!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Categoria categoria = new Categoria();
                categoria.Descricao = txtCategoria.Text;

                forcaContext.Categoria.Add(categoria);
                forcaContext.SaveChanges();

                MessageBox.Show("Registro incluído com sucesso!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PreencherGrid();
                txtCategoria.Text = string.Empty;
            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            PreencherGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione um registro para alterar!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Preencha o campo com a descrição da categoria!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idSel = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);

                Categoria categoria = forcaContext.Categoria.FirstOrDefault(cat => cat.Id == idSel);
                categoria.Descricao = txtCategoria.Text;
                forcaContext.SaveChanges();

                MessageBox.Show("Registro alterado com sucesso!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PreencherGrid();
                txtCategoria.Text = string.Empty;
            }
        }

        private void dgvCategoria_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoria.Text = dgvCategoria[1, e.RowIndex].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione um registro para excluir!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idSel = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);

                Categoria categoria = forcaContext.Categoria.FirstOrDefault(cat => cat.Id == idSel);
                forcaContext.Categoria.Remove(categoria);
                forcaContext.SaveChanges();

                MessageBox.Show("Registro excluído com sucesso!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PreencherGrid();
                txtCategoria.Text = string.Empty;
            }
        }
    }
}
