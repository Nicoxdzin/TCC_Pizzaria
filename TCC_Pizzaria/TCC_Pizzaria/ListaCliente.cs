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

namespace TCC_Pizzaria
{
    public partial class ListaCliente : Form
    {
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
    }
}
