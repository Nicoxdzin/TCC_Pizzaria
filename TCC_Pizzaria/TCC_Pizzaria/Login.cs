using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Controller1;
using model1;

namespace TCC_Pizzaria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UserController usu_controller = new UserController();
            Usuario usuario= new Usuario();
            usuario.usuario = txtNome.Text;
            usuario.senha  = txtSenha.Text;
            usuario = usu_controller.Entrar(usuario);
            if(usuario.logado == true) {

              if (usuario.perfil == 1)
            {
                Admin admin = new Admin();
                admin.ShowDialog();
            }
            else
            {
                Funcionario funcionario = new Funcionario();
                funcionario.ShowDialog();
            }
            
            }
            



          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserController usu_controller = new UserController();
            Usuario usuario = new Usuario();
            usuario.usuario = txtNome.Text;
            usuario.senha = txtSenha.Text;
            usuario = usu_controller.Entrar(usuario);
            if (usuario.logado == true)
            {

                if (usuario.perfil == 1)
                {
                    Admin admin = new Admin();
                    admin.ShowDialog();
                }
                else
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.ShowDialog();
                }

            }
            else 
            {
                MsgSenhaIncorreta.Show("Senha Incorreta!");

            }

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();

            if(con.conectar() == true){
                MessageBox.Show("Conectado");
            }

        }

        private void txtSenha_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
