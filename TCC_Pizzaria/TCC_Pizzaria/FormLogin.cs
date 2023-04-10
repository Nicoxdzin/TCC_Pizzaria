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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }
    }
}
