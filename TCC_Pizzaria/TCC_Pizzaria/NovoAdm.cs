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
    public partial class NovoAdm : Form
    {
        public NovoAdm()
        {
            InitializeComponent();
        }

        private void NovoAdm_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSobrenome.Text == "" || txtCpf.Text == "" || txtSenha.Text == "")
            {
                msgErroCampoBranco.Show("Preencha todos os campos para realizar o cadastro.");
            }
            else
            {
                AdminController admin_controller = new AdminController();
                Admin admin = new Admin();
                
               
                admin.Nome = txtNome.Text;
                admin.Sobrenome = txtSobrenome.Text;
                admin.CPF = txtCpf.Text;
                admin.Senha = txtSenha.Text;

                admin = admin_controller.Cadastrar(admin);

                if (admin.Id < 0)
               {
                    msgErroCadastro.Show("Erro ao cadastrar ADM!");
                }
               else
                {
                    msgSucessoCadastro.Show("ADM cadastrado com sucesso.");


                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
