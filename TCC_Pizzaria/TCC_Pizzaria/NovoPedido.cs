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
            if (txtProduto1.Text == "" || txtCliente.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "" || txtProduto1.Text == "")
            {
                msgErro.Show("Preencha todos os campos para realizar o cadastro.");
            }
            else
            {
                PedidoController pedido_controller = new PedidoController();
                Pedido pedido = new Pedido();
                pedido.Produto = txtProduto1.Text;
                pedido.Nome_cliente = txtCliente.Text;
                pedido.Telefone = txtTelefone.Text;
                pedido.Endereco = txtEndereco.Text;
                pedido.Observacoes = txtProduto1.Text;
                pedido = pedido_controller.Cadastrar(pedido);

                if (pedido.Id < 0)
                {            
                    msgErro.Show("Erro ao cadastrar pedido");
                }
                else
                {
                    msgSucesso.Show("Pedido cadastrado com sucesso!");


                }
            }
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio1.Checked)
            {
                lblSabor1.Enabled = true;
                lblSabor2.Enabled = false;
                lblSabor3.Enabled = false;
                txtProduto1.Enabled = true;
                txtProduto2.Enabled = false;
                txtProduto3.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NovoPedido_Load(object sender, EventArgs e)
        {
            lblSabor1.Enabled = false;
            lblSabor2.Enabled = false;
            lblSabor3.Enabled = false;
            txtProduto1.Enabled = false;
            txtProduto2.Enabled = false;
            txtProduto3.Enabled = false;
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2.Checked)
            {
                lblSabor1.Enabled = true;
                lblSabor2.Enabled = true;
                lblSabor3.Enabled = false;
                txtProduto1.Enabled = true;
                txtProduto2.Enabled = true;
                txtProduto3.Enabled = false;
            }
        }

        private void radio3_CheckedChanged(object sender, EventArgs e)
        {
            if (radio3.Checked)
            {
                lblSabor1.Enabled = true;
                lblSabor2.Enabled = true;
                lblSabor3.Enabled = true;
                txtProduto1.Enabled = true;
                txtProduto2.Enabled = true;
                txtProduto3.Enabled = true;
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                txtTelefone.Focus();
            }
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                txtEndereco.Focus();
            }
        }

        private void txtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                txtObs.Focus();
            }
        }

        private void txtObs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnCadastrar.PerformClick();
            }
        }

        private void NovoPedido_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
