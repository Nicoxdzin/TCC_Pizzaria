using Guna.UI2.WinForms;
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
           
            //menuStrip1.Renderer = new CustomToolStripRenderer();

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

        private void mtsClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Clientes());
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
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

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint_1(object sender, PaintEventArgs e)
        { 

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cliente());
            label1.Text = "Usuários";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ListaPedido());
            label1.Text = "Pedidos";
        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FuncPnlPrincipal_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (FuncPnlPrincipal != null)//temporario
            {
                activeForm.Close();
            }
            label1.Text = "Início";
        }

        private void guna2ShadowPanel1_Paint_2(object sender, PaintEventArgs e)
        {
         
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ListaPedido());
            label1.Text = "Pedidos";
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cliente());
            label1.Text = "Clientes";
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GraficoPedido());
            label1.Text = "Gráficos";
        }
    }
}
