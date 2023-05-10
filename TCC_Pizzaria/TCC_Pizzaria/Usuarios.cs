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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

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
            pnlUsuario.Controls.Add(childForm);
            pnlUsuario.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblCurrentChildForm.text = childForm.Name;

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cadastro_Usuario());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Listar_Usuario());
        }
    }
}
