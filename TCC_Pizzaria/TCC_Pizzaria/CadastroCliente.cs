using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model1;
using Controller;

namespace TCC_Pizzaria
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void Cadastro_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCpf.Text == "" || txtNumero_Telefone.Text == "" || txtCep.Text == "" || txtNumero_Casa.Text == "" || txtReferencia.Text == "")
            {
                // Exibe uma mensagem de erro caso algum dos campos esteja vazio.
                msgErro.Show("Preencha todos os campos para realizar o cadastro do usuário.");
            }
            else
            {
                UserController user_controller = new UserController();
                Cliente cadastro = new Cliente();
                cadastro.nome = txtNome.Text;
                cadastro.cpf = txtCpf.Text;
                cadastro.numero_tel = txtNumero_Telefone.Text;
                cadastro.cep = txtCep.Text;
                cadastro.numero_casa = txtNumero_Casa.Text;
                cadastro.referencia = txtReferencia.Text;
                cadastro = user_controller.Cadastrar(cadastro);

                if (cadastro.Id < 0)
                {
                    // O cadastro foi realizado com sucesso.                
                    msgErro.Show("Erro ao cadastrar usuário!");
                }
                else
                {
                    // Ocorreu um erro ao realizar o cadastro.
                    msgSucesso.Show("Usuário cadastrado com sucesso.");


                }

            }
        }
    }
}
