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
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

       

        private void pnlPedidos_Paint(object sender, PaintEventArgs e)
        {

        }

 

        private void Pedidos_Load(object sender, EventArgs e)
        {
            btnLight.Enabled = false;
            btnDark.Enabled = false;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlListaPedido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDark_Click(object sender, EventArgs e)
        {

        }
    }
}
