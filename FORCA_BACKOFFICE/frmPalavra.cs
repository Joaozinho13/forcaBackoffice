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
    public partial class frmPalavra : Form
    {
        private class Dificuldade
        {
            public int Codigo { get; set; }
            public string Descricao { get; set; }
        }

        FORCAEntities forcaContext = new FORCAEntities();

        public frmPalavra()
        {
            InitializeComponent();
        }

        private void frmPalavra_Load(object sender, EventArgs e)
        {
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "Descricao";
            cbCategoria.DataSource = (from Categoria cat in forcaContext.Categoria select cat).ToList();

            List<Dificuldade> dificuldades = new List<Dificuldade>();
            dificuldades.Add(new Dificuldade() { Codigo = 0, Descricao = "Baixa" });
            dificuldades.Add(new Dificuldade() { Codigo = 1, Descricao = "Média" });
            dificuldades.Add(new Dificuldade() { Codigo = 2, Descricao = "Alta" });

            cbDificuldade.ValueMember = "Codigo";
            cbDificuldade.DisplayMember = "Descricao";
            cbDificuldade.DataSource = dificuldades;

            PreencherGrid();
        }

        private void PreencherGrid()
        {
            dgvPalavra.DataSource = (from pal in forcaContext.Palavra
                                     let dificuldade = pal.IDDificuldade == "1" ? "Baixa" :
                                                       pal.IDDificuldade == "2" ? "Média" :
                                                       "Alta"
                                     select new
                                     {
                                         ID = pal.Id,
                                         Palavra = pal.Palavra1,
                                         Categoria = (from categoria in forcaContext.Categoria where categoria.Id.ToString().Equals(pal.IDCategoria) select categoria.Descricao).FirstOrDefault(),
                                         Dificuldade = dificuldade
                                     }).ToList();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPalavra.Text))
            {
                MessageBox.Show("Preencha o campo com a descrição da palavra!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Palavra palavra = new Palavra();

                palavra.Palavra1 = txtPalavra.Text;
                palavra.IDCategoria = cbCategoria.SelectedValue.ToString();
                palavra.IDDificuldade = cbDificuldade.SelectedValue.ToString();

                forcaContext.Palavra.Add(palavra);
                forcaContext.SaveChanges();

                MessageBox.Show("Registro incluído com sucesso!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PreencherGrid();
                txtPalavra.Text = string.Empty;
            }
        }

        private void dgvPalavra_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtPalavra.Text = dgvPalavra[1, e.RowIndex].Value.ToString();
            cbCategoria.SelectedIndex = cbCategoria.FindStringExact(dgvPalavra[2, e.RowIndex].Value.ToString());
            cbDificuldade.SelectedIndex = cbDificuldade.FindStringExact(dgvPalavra[3, e.RowIndex].Value.ToString());
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvPalavra.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione um registro para alterar!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtPalavra.Text))
            {
                MessageBox.Show("Preencha o campo com a descrição da palavra!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idSel = Convert.ToInt32(dgvPalavra.SelectedRows[0].Cells[0].Value);
                Palavra palavra = forcaContext.Palavra.FirstOrDefault(pal => pal.Id == idSel);
                palavra.Palavra1 = txtPalavra.Text;
                palavra.IDCategoria = cbCategoria.SelectedValue.ToString();
                palavra.IDDificuldade = cbDificuldade.SelectedValue.ToString();
                forcaContext.SaveChanges();

                MessageBox.Show("Registro alterado com sucesso!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PreencherGrid();
                txtPalavra.Text = string.Empty;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPalavra.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione um registro para excluir!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idSel = Convert.ToInt32(dgvPalavra.SelectedRows[0].Cells[0].Value);

                Palavra palavra = forcaContext.Palavra.FirstOrDefault(pal => pal.Id == idSel);
                forcaContext.Palavra.Remove(palavra);
                forcaContext.SaveChanges();

                MessageBox.Show("Registro excluído com sucesso!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PreencherGrid();
                txtPalavra.Text = string.Empty;
            }
        }
    }
}
