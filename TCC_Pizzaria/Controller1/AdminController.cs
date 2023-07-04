﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using model1;

namespace Controller1
{
    public class AdminController
    {
        public AdminController() { }
        Conexao conn =  new Conexao();

        public Admin Entrar(Admin adm)
        {
            String logar = "SELECT * FROM tb_adm WHERE cpf=@cpf AND senha=@senha";
            SqlConnection conexao = conn.getConexao();
            SqlCommand comando = new SqlCommand(logar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@cpf", adm.CPF);
            comando.Parameters.AddWithValue("@senha", adm.Senha);
            SqlDataReader registro = comando.ExecuteReader();//executa a consulta
            if (registro.HasRows)
            {
                registro.Read();
                adm.CPF = Convert.ToString(registro["cpf"]);
                adm.Senha = Convert.ToString(registro["senha"]);
                adm.logado = true;


            }
            return adm;
        }
    }
}
