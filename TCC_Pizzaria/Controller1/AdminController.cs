using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using model1;
using Mysqlx.Session;
using static Controller1.AdminController;

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

        public bool VerificarCPF(string cpf)
        {
            bool exists = false;                      
            string query = "SELECT COUNT(*) FROM tb_adm WHERE cpf = @cpf";
            SqlConnection conexao = conn.getConexao();

            SqlCommand command = new SqlCommand(query, conexao);
                {
                    command.Parameters.AddWithValue("@cpf", cpf);

                    conexao.Open();
                    int count = (int)command.ExecuteScalar();
                    exists = count > 0;
                }

            return exists;
        }

        public Admin Cadastrar(Admin admin)
        {
            admin.Senha = Criptografia.Criptografar(admin.Senha);
            String cadastrar = "INSERT INTO tb_adm values (@nome,@sobrenome,@cpf,@dataCadastro,@senha)";
            SqlConnection conexao = conn.getConexao();      
            SqlCommand comando = new SqlCommand(cadastrar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@nome", admin.Nome);
            comando.Parameters.AddWithValue("@sobrenome", admin.Sobrenome);
            comando.Parameters.AddWithValue("@cpf", admin.CPF);
            comando.Parameters.AddWithValue("@dataCadastro", admin.DataCadastro);
            comando.Parameters.AddWithValue("@senha", admin.Senha);
            
            comando.ExecuteReader();

            return admin;

        }

        public List<Admin> ObterAdmin()
        {
            List<Admin> admins = new List<Admin>();


            {
                string query = "SELECT * FROM tb_adm";
                SqlConnection conexao = conn.getConexao();
                SqlCommand command = new SqlCommand(query, conexao);
                conexao.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Admin admin = new Admin();
                    admin.Id = reader.GetInt32(0);
                    admin.Nome = reader.GetString(1);
                    admin.Sobrenome = reader.GetString(2);
                    admin.CPF = reader.GetString(3);                  
                    admin.DataCadastro = reader.GetDateTime(4);

                    admins.Add(admin);
                }

                reader.Close();
            }

            return admins;
        }

        public Admin DeletarAdmin(Admin admin)
        {
            string deletar = "DELETE FROM tb_adm WHERE id = @Id";
            SqlConnection conexao = conn.getConexao();
            SqlCommand comando = new SqlCommand(deletar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@Id", admin.Id);
            comando.ExecuteNonQuery();

            return admin;
        }

        public class Criptografia
        {
            private static int deslocamento = 3; // Número de posições a serem deslocadas no alfabeto

            public static string Criptografar(string textoPlano)
            {
                StringBuilder textoCriptografado = new StringBuilder();

                foreach (char c in textoPlano)
                {
                    if (char.IsLetter(c))
                    {
                        char letraCriptografada = (char)(c + deslocamento);

                        if (!char.IsLetter(letraCriptografada))
                        {
                            letraCriptografada = (char)(c - (26 - deslocamento)); // Volta ao início do alfabeto se necessário
                        }

                        textoCriptografado.Append(letraCriptografada);
                    }
                    else
                    {
                        textoCriptografado.Append(c); // Mantém os caracteres não alfabéticos
                    }
                }

                return textoCriptografado.ToString();
            }

            public static string Descriptografar(string textoCriptografado)
            {
                StringBuilder textoDescriptografado = new StringBuilder();

                foreach (char c in textoCriptografado)
                {
                    if (char.IsLetter(c))
                    {
                        char letraDescriptografada = (char)(c - deslocamento);

                        if (!char.IsLetter(letraDescriptografada))
                        {
                            letraDescriptografada = (char)(c + (26 - deslocamento)); // Volta ao fim do alfabeto se necessário
                        }

                        textoDescriptografado.Append(letraDescriptografada);
                    }
                    else
                    {
                        textoDescriptografado.Append(c); // Mantém os caracteres não alfabéticos
                    }
                }

                return textoDescriptografado.ToString();
            }
        }
        








    }
}
