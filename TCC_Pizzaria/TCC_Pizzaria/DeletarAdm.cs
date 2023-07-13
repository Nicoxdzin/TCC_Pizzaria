using Controller1;
using model1;
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

namespace TCC_Pizzaria
{
    public partial class DeletarAdm : Form
    {
        public DeletarAdm()
        {
            InitializeComponent();
        }

        private AdminController adminController;

        private void ListaAdm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ListaAdm.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma linha selecionada. Selecione uma linha antes de prosseguir.");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza de que deseja excluir o pedido?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    AdminController admin_controller = new AdminController();
                    int id = (int)ListaAdm.SelectedRows[0].Cells[0].Value;
                    Admin admin = new Admin { Id = id };
                    admin = admin_controller.DeletarAdmin(admin);
                    MessageBox.Show("Excluído com sucesso!");
                    ListaAdm.DataSource = adminController.ObterAdmin();
                }

            }
        }

        private void DeletarAdm_Load(object sender, EventArgs e)
        {
            adminController = new AdminController();

            ListaAdm.AutoGenerateColumns = true;
            ListaAdm.DataSource = adminController.ObterAdmin();
        }
    }
}
