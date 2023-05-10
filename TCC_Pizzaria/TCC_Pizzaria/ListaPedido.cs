using Controller1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Pizzaria
{
    public partial class ListaPedido : Form
    {
        private PedidoController pedidoController;
        public ListaPedido()
        {           
           InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaPedido_Load(object sender, EventArgs e)
        {
            pedidoController = new PedidoController();

            dtgView1.AutoGenerateColumns = true;
            dtgView1.DataSource = pedidoController.ObterPedidos();
        }
    }
}
