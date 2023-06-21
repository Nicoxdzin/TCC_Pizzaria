using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Controller1;
using model1;

namespace TCC_Pizzaria
{
    public partial class ListaCliente : Form
    {
        private UserController userController;

        public ListaCliente()
        {
            InitializeComponent();
        }
        private Form ActiveForm = null;

        private void dtgViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaCliente_Load(object sender, EventArgs e)
        {
            UserController user = new UserController();
            dtgViewCliente.AutoGenerateColumns = true;
            dtgViewCliente.DataSource = user.ObterClientes();
        }

        public void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlCliente1.Controls.Add(childForm);
            pnlCliente1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblCurrentChildForm.text = childForm.Name;

        }


        private void btnCadastroNovoCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CadastroCliente());
        }

        private void btnDeletarCliente_Click(object sender, EventArgs e)
        {
            if (dtgViewCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma linha selecionada. Selecione uma linha antes de prosseguir.");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza de que deseja excluir o cliente cadastrado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    UserController user_controller = new UserController();
                    int id = (int)dtgViewCliente.SelectedRows[0].Cells[0].Value;
                    Cliente cliente = new Cliente {Id = id};
                    cliente = user_controller.DeletarCliente(cliente);
                    MessageBox.Show("Excluído com sucesso!");
                    dtgViewCliente.DataSource = user_controller.ObterClientes();
                }

            }
        }
    }
}
