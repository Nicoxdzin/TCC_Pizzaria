using Controller;
using model1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller1;
using model1;

namespace TCC_Pizzaria
{
    public partial class NovoPedido : Form
    {
        public NovoPedido()
        {
            InitializeComponent();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            PedidoController pedido_controller = new PedidoController();
            Pedido pedido = new Pedido();
            pedido.Produto = txtProduto.Text;
            pedido.Nome_cliente = txtCliente.Text;
            pedido.Telefone = txtTelefone.Text;
            pedido.Endereco = txtEndereco.Text;
            pedido.Observacoes = txtObs.Text;
            pedido = pedido_controller.Cadastrar(pedido);

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
