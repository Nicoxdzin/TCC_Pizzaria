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

        private void dtgViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaCliente_Load(object sender, EventArgs e)
        {
            UserController user = new UserController();
            dtgViewCliente.AutoGenerateColumns = true;
            dtgViewCliente.DataSource = user.ObterClientes();
        }
    }
}
