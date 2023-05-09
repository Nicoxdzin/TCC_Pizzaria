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

        Conexao conn = new Conexao();
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
    }
}
