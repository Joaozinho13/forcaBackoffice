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
    public partial class frmUsuario : Form
    {
        private class StatusUsuario
        {
            public int Codigo { get; set; }
            public string Descricao { get; set; }
        }

        FORCAEntities forcaContext = new FORCAEntities();

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void PreencherGrid()
        {
            dgvUsuario.DataSource = (from usu in forcaContext.AspNetUsers
                                     select new
                                     {
                                         ID = usu.Id,
                                         Nome = usu.UserName,
                                         Email = usu.Email
                                     }).ToList();

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

            PreencherGrid();
        }

       
        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
     
        }

      

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione um registro para excluir!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string idSel = dgvUsuario.SelectedRows[0].Cells[0].Value.ToString();

                AspNetUsers usuario = forcaContext.AspNetUsers.FirstOrDefault(usu => usu.Id == idSel);
                forcaContext.AspNetUsers.Remove(usuario);
                forcaContext.SaveChanges();

                MessageBox.Show("Registro excluído com sucesso!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PreencherGrid();
                LimparCampos();
            }
        }

        private void dgvUsuario_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dgvUsuario[1, e.RowIndex].Value.ToString();
            txtEmail.Text = dgvUsuario[2, e.RowIndex].Value.ToString();
        }
    }
}
