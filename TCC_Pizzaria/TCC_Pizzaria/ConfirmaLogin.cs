using System;
using System.Windows.Forms;
using model1;
using Controller1;



namespace TCC_Pizzaria
{
    public partial class ConfirmaLogin : Form
    {
        public ConfirmaLogin()
        {
            InitializeComponent();
        }

        private void GraficoPedido_Load(object sender, EventArgs e)
        {
            
        }

        private void grafico1_Click(object sender, EventArgs e)
        {

        }

        private void entrar_Click(object sender, EventArgs e)
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
    }
}
