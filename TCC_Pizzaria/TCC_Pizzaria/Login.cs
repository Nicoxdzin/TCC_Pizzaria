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
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminController adm_controller = new AdminController();
            Admin admin = new Admin();
            admin.CPF = txtCPF.Text;
            admin.Senha = txtSenha.Text;
            admin = adm_controller.Entrar(admin);
            if (admin.logado == true)
            {
         
                Funcionario funcionario = new Funcionario();
                    funcionario.ShowDialog();
                this.Close();

            }
            else 
            {
                MsgSenhaIncorreta.Show("Senha Incorreta!");

            }

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
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

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnEntrar.PerformClick(); 
            }
        }
    }
}
