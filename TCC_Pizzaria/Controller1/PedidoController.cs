using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model1;

namespace Controller1
{
    public class PedidoController
    {

        public Conexao conn = new Conexao();
        public PedidoController() { }

        public Pedido Cadastrar(Pedido pedido)
        {
            String cadastrar = "INSERT INTO tb_pedido values (@Produto,@Nome_cliente,@Telefone,@Endereco,@Observacoes)";
            SqlConnection conexao = conn.getConexao();
            SqlCommand comando = new SqlCommand(cadastrar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@Produto", pedido.Produto);
            comando.Parameters.AddWithValue("@Nome_cliente", pedido.Nome_cliente);
            comando.Parameters.AddWithValue("@Telefone", pedido.Telefone);
            comando.Parameters.AddWithValue("@Endereco", pedido.Endereco);
            comando.Parameters.AddWithValue("@Observacoes", pedido.Observacoes);
            comando.ExecuteReader();
            
            return pedido;
        }

        public List<Pedido> ObterPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();

  
            {
                string query = "SELECT * FROM tb_pedido";
                SqlConnection conexao = conn.getConexao();
                SqlCommand command = new SqlCommand(query, conexao);
                conexao.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Pedido pedido = new Pedido();
                    pedido.Id = reader.GetInt32(0);
                    pedido.Produto = reader.GetString(1);
                    pedido.Nome_cliente = reader.GetString(2);
                    pedido.Telefone = reader.GetString(3);
                    pedido.Endereco = reader.GetString(4);
                    pedido.Observacoes = reader.GetString(5);

                    pedidos.Add(pedido);
                }

                reader.Close();
            }

            return pedidos;
        }
    }

}
