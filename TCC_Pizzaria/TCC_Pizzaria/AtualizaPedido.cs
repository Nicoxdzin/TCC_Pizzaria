using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using model1;

namespace TCC_Pizzaria
{
    public partial class AtualizaPedido : Form
    {
        private int pedidoId;
        public AtualizaPedido(int id)
        {
            InitializeComponent();
            pedidoId = id;
            label5.Text = pedidoId.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizaPedido_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
