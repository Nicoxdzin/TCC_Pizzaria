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
    public partial class AtualizaCliente : Form
    {
        private int ClienteId;

        public AtualizaCliente(int id)
        {
            InitializeComponent();
            
            ClienteId = id;
            labelAttCliente.Text = ClienteId.ToString();


            Cliente cliente = new Cliente();

            if (cliente != null)
            {
                UserController controller = new UserController();
                Cliente clienteObtido = controller.ObterClientePorId(ClienteId);

                txtAttCliente.Text = clienteObtido.nome;
                txtAttCpf.Text = clienteObtido.cpf;
                txtAttNumeroTel.Text = clienteObtido.numero_tel;
                txtAttCep.Text = clienteObtido.cep;
                txtAttNumeroCasa.Text = clienteObtido.numero_casa;
                txtAttReferencia.Text = clienteObtido.referencia;
                
            }
            else
            {
                MessageBox.Show("Cliente cadastrado não encontrado.");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizaCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtAttCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            Cliente clienteObtido = controller.ObterClientePorId(ClienteId);

            if (txtAttCliente.Text != clienteObtido.nome ||
                txtAttCpf.Text != clienteObtido.cpf ||
                txtAttNumeroTel.Text != clienteObtido.numero_tel ||
                txtAttCep.Text != clienteObtido.cep ||
                txtAttNumeroCasa.Text != clienteObtido.numero_casa ||
                txtAttReferencia.Text != clienteObtido.referencia 
                                                     
               )
            {
                Cliente clienteAtualizado = new Cliente();
                clienteAtualizado.Id = ClienteId;
                clienteAtualizado.nome = txtAttCliente.Text;
                clienteAtualizado.cpf = txtAttCpf.Text;
                clienteAtualizado.numero_tel = txtAttNumeroTel.Text;
                clienteAtualizado.cep = txtAttCep.Text;
                clienteAtualizado.numero_casa = txtAttNumeroCasa.Text;
                clienteAtualizado.referencia = txtAttReferencia.Text;


                bool atualizado = controller.AtualizarClientePorId(clienteAtualizado);

                if (atualizado)
                {
                    MessageBox.Show("Atualizado com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar.");
                }
            }
        }
    }
}
