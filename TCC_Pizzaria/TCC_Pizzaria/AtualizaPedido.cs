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
using Guna.UI2.AnimatorNS;
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

            Pedido pedido = new Pedido();

            if (pedido != null)
            {
                PedidoController controller = new PedidoController();
                Pedido pedidoObtido = controller.ObterPedidoPorId(pedidoId);

                txtCliente.Text = pedidoObtido.Nome_cliente;
                txtTelefone.Text = pedidoObtido.Telefone;
                txtEndereco.Text = pedidoObtido.Endereco;
                txtObs.Text = pedidoObtido.Observacoes;
                txtProduto1.Text = pedidoObtido.Produto;
               

            }
            else
            {
                MessageBox.Show("Pedido não encontrado.");
            }

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

            PedidoController controller = new PedidoController();
            Pedido pedidoObtido = controller.ObterPedidoPorId(pedidoId);

            if (txtCliente.Text != pedidoObtido.Nome_cliente ||
                txtTelefone.Text != pedidoObtido.Telefone ||
                txtEndereco.Text != pedidoObtido.Endereco ||
                txtObs.Text != pedidoObtido.Observacoes ||
                txtProduto1.Text != pedidoObtido.Produto)
            {
                Pedido pedidoAtualizado = new Pedido();
                pedidoAtualizado.Id = pedidoId;
                pedidoAtualizado.Nome_cliente = txtCliente.Text;
                pedidoAtualizado.Telefone = txtTelefone.Text;
                pedidoAtualizado.Endereco = txtEndereco.Text;
                pedidoAtualizado.Observacoes = txtObs.Text;
                pedidoAtualizado.Produto = txtProduto1.Text;

                bool atualizado = controller.AtualizarPedidoPorId(pedidoAtualizado);

                if (atualizado)
                {
                    MessageBox.Show("Pedido atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o pedido.");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void txtProduto3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
