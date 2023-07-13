using Controller1;
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

namespace TCC_Pizzaria
{
    public partial class NovoSabor : Form
    {
        public NovoSabor()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
            private void btnEntrar_Click(object sender, EventArgs e)
            {
                if (txtSabor.Text == "")
                {
                    msgErroCampoBranco.Show("Preencha todos o campo para realizar o cadastro.");
                }
                else
                {
                    SaborController sabor_controller = new SaborController();
                    Sabor sabor = new Sabor();


                    sabor.SaborPizza = txtSabor.Text;
                    
                                     
                        if (sabor.Id < 0)
                        {
                            msgErroCadastro.Show("Erro ao cadastrar sabor!");
                        }
                        else
                        {
                            sabor = sabor_controller.Cadastrar(sabor);
                            msgSucessoCadastro.Show("Sabor cadastrado com sucesso.");
                            this.Close();
                       }
                    
                }
            }

        private void NovoSabor_Load(object sender, EventArgs e)
        {

        }
    }
}
