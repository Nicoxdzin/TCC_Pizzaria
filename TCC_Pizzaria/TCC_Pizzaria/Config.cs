﻿using System;
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
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

       

        private void pnlPedidos_Paint(object sender, PaintEventArgs e)
        {

        }

 

        private void Pedidos_Load(object sender, EventArgs e)
        {
            btnLight.Enabled = false;
            btnDark.Enabled = false;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlListaPedido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDark_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoAdm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NovoAdm novoadm = new NovoAdm();
            novoadm.ShowDialog();
        }

        private void btnDeletarAdm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeletarAdm deletarAdm = new DeletarAdm();
            deletarAdm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NovoSabor novosabor = new NovoSabor();
            novosabor.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeletarSabor deletarsabor = new DeletarSabor();
            deletarsabor.ShowDialog();
        }
    }
}
