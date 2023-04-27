﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Controller1;
using model1;

namespace TCC_Pizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        }
    }
}
