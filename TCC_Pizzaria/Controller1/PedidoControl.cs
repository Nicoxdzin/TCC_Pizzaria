using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model1;

namespace Controller1
{
    public class PedidoController
    {
        Conexao con = new Conexao();
        public PedidoController() { }

        public bool Cadastrar(Pedido pedido)
        {
            String cadastrar = "INSERT INTO tb_usuario values (@Produto,@Nome_cliente,@Telefone,@Endereco,@Descricao)";

            return true;
        }
    }
}
