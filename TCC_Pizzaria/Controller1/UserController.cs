using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Controller1;
using model1;

namespace Controller
{
    public class UserController
    {
        Conexao conn = new Conexao();

        public UserController() {
            
        }

        public Usuario Entrar(Usuario usu )
        {
            String logar = "SELECT * FROM tb_usuario WHERE usuario=@usuario AND senha=@senha";
            SqlConnection conexao = conn.getConexao();
            SqlCommand comando = new SqlCommand(logar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@usuario", usu.usuario);
            comando.Parameters.AddWithValue("@senha", usu.senha);
            SqlDataReader registro = comando.ExecuteReader();//executa a consulta
            if (registro.HasRows)
            {
                registro.Read();
                usu.usuario = Convert.ToString(registro["usuario"]);
                usu.senha = Convert.ToString(registro["senha"]);
                usu.perfil = Convert.ToInt16(registro["perfil"]);
                usu.logado = true;


            }
            return usu;
        }

        public Cliente Cadastrar(Cliente cadastro)
        {
            String cadastrar = "INSERT INTO tb_cadastro values (@nome,@cpf,@numero_tel,@cep,@numero_casa,@referencia)";
            SqlConnection conexao = conn.getConexao();
            SqlCommand comando = new SqlCommand(cadastrar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@nome", cadastro.nome);
            comando.Parameters.AddWithValue("@cpf", cadastro.cpf);
            comando.Parameters.AddWithValue("@numero_tel", cadastro.numero_tel);
            comando.Parameters.AddWithValue("@cep", cadastro.cep);
            comando.Parameters.AddWithValue("@numero_casa", cadastro.numero_casa);
            comando.Parameters.AddWithValue("@referencia", cadastro.referencia);
            comando.ExecuteReader();

            return cadastro;

        }

        public void Editar()
        {

        }
        public List<Cliente> ObterClientes()
        {
            List<Cliente> clientes = new List<Cliente>();


            {
                string query = "SELECT * FROM tb_cadastro";
                SqlConnection conexao = conn.getConexao();
                SqlCommand command = new SqlCommand(query, conexao);
                conexao.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cadastro = new Cliente();
                    cadastro.Id = reader.GetInt32(0);
                    cadastro.nome = reader.GetString(1);
                    cadastro.cpf = reader.GetString(2);
                    cadastro.numero_tel = reader.GetString(3);
                    cadastro.cep = reader.GetString(4);
                    cadastro.numero_casa = reader.GetString(5);
                    cadastro.referencia = reader.GetString(6);

                    clientes.Add(cadastro);
                }

                reader.Close();
            }

            return clientes;
        }

    }
}
