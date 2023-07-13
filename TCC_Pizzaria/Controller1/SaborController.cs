using model1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static Controller1.AdminController;

namespace Controller1
{
    public class SaborController
    {
        public SaborController() { }
        Conexao conn = new Conexao();

           

        public Sabor Cadastrar(Sabor sabor)
        {        
            String cadastrar = "INSERT INTO tb_sabor values (@sabor)";
            SqlConnection conexao = conn.getConexao();
            SqlCommand comando = new SqlCommand(cadastrar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@sabor", sabor.SaborPizza);
            

            comando.ExecuteReader();

            return sabor;

        }

        public List<Sabor> ObterSabor()
        {
            List<Sabor> sabores = new List<Sabor>();

            {
                string query = "SELECT * FROM tb_sabor";
                SqlConnection conexao = conn.getConexao();
                SqlCommand command = new SqlCommand(query, conexao);
                conexao.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Sabor sabor = new Sabor();
                    sabor.Id = reader.GetInt32(0);
                    sabor.SaborPizza = reader.GetString(1);                   

                    sabores.Add(sabor);
                }

                reader.Close();
            }

            return sabores;
        }

        public Sabor DeletarSabor(Sabor sabor)
        {
            string deletar = "DELETE FROM tb_sabor WHERE id = @Id";
            SqlConnection conexao = conn.getConexao();
            SqlCommand comando = new SqlCommand(deletar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@Id", sabor.Id);
            comando.ExecuteNonQuery();

            return sabor;
        }
    }
}
