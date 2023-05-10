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
            if (txtProduto.Text == "" || txtCliente.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "" || txtObs.Text == "")
            {
                // Exibe uma mensagem de erro caso algum dos campos esteja vazio.
                msgErro.Show("Preencha todos os campos para realizar o cadastro.");
            }
            else
            {
                PedidoController pedido_controller = new PedidoController();
                Pedido pedido = new Pedido();
                pedido.Produto = txtProduto.Text;
                pedido.Nome_cliente = txtCliente.Text;
                pedido.Telefone = txtTelefone.Text;
                pedido.Endereco = txtEndereco.Text;
                pedido.Observacoes = txtObs.Text;
                pedido = pedido_controller.Cadastrar(pedido);

                if (pedido.Id < 0)
                {
                    // O cadastro foi realizado com sucesso.                
                    msgErro.Show("Erro ao cadastrar pedido");
                }
                else
                {
                    // Ocorreu um erro ao realizar o cadastro.
                    msgSucesso.Show("Pedido cadastrado com sucesso!");


                }
            }
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
