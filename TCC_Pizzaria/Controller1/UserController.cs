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
        public Cliente DeletarCliente(Cliente cliente)
        {
            string deletar = "DELETE FROM tb_cadastro WHERE id = @Id";
            SqlConnection conexao = conn.getConexao();
            SqlCommand comando = new SqlCommand(deletar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@Id", cliente.Id);
            comando.ExecuteNonQuery();
            
            return cliente;
        }
        public bool AtualizarCliente(Cliente cliente)
        {
            string atualizar = "UPDATE tb_cadastro SET nome = @nome, cpf = @cpf, numero_tel = @numero_tel, cep = @cep, numero_casa = @numero_casa, referencia = @eferencia, WHERE Id = @Id";

            SqlConnection conexao = conn.getConexao();
            SqlCommand comando = new SqlCommand(atualizar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@nome", cliente.nome);
            comando.Parameters.AddWithValue("@cpf", cliente.cpf);
            comando.Parameters.AddWithValue("@numero_tel", cliente.numero_tel);
            comando.Parameters.AddWithValue("@cep", cliente.cep);
            comando.Parameters.AddWithValue("@numero_casa", cliente.numero_casa);
            comando.Parameters.AddWithValue("@referencia", cliente.referencia);
            comando.Parameters.AddWithValue("@Id", cliente.Id);
            int rowsAffected1 = comando.ExecuteNonQuery();
            conexao.Close();

            return rowsAffected1 > 0;
        }
        public Cliente ObterClientePorId(int Id)
        {
            Cliente cliente = null;

            string query = "SELECT * FROM tb_cadastro WHERE id = " + Id;
            SqlConnection conexao = conn.getConexao();
            SqlCommand command = new SqlCommand(query, conexao);
            conexao.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                cliente = new Cliente();
                cliente.Id = reader.GetInt32(0);
                cliente.nome = reader.GetString(1);
                cliente.cpf = reader.GetString(2);
                cliente.numero_tel = reader.GetString(3);
                cliente.cep = reader.GetString(4);
                cliente.numero_casa = reader.GetString(5);
                cliente.referencia = reader.GetString(6);
            }

            reader.Close();

            return cliente;

        }
        public bool AtualizarClientePorId(Cliente cliente)
        {
            string atualizar = "UPDATE tb_cadastro SET nome = @nome, cpf = @cpf, numero_tel = @numero_tel, cep = @cep, numero_casa = @numero_casa WHERE Id = @Id";

            SqlConnection conexao = conn.getConexao();
            SqlCommand comando = new SqlCommand(atualizar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@nome", cliente.nome);
            comando.Parameters.AddWithValue("@cpf", cliente.cpf);
            comando.Parameters.AddWithValue("@numero_tel", cliente.numero_tel);
            comando.Parameters.AddWithValue("@cep", cliente.cep);
            comando.Parameters.AddWithValue("@numero_casa", cliente.numero_casa);
            comando.Parameters.AddWithValue("@referencia", cliente.referencia);
            comando.Parameters.AddWithValue("@Id", cliente.Id);
            int rowsAffected = comando.ExecuteNonQuery();
            conexao.Close();

            return rowsAffected > 0;
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
