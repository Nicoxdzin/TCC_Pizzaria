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
    public partial class Funcionario : Form
    {  
        public Funcionario()
        {
            InitializeComponent();
        } 
        
        private Form activeForm = null;

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            FuncPnlPrincipal.Controls.Add(childForm);
            FuncPnlPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblCurrentChildForm.text = childForm.Name;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void mtsClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Clientes());
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            if (FuncPnlPrincipal != null)//temporario
            {
                activeForm.Close();
            }
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void FuncPnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Clientes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
