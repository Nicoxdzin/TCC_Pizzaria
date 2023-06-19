using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model1
{
    public class Pedido
    {
        public int Id { get; set; }

        public string Nome_cliente { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Sabor1{ get; set; }
        public string Sabor2 { get; set; }
        public string Sabor3 { get; set; }
        public string Sabor4 { get; set; }
        public string Observacoes { get; set; }
        public string Tamanho { get; set; }
        public DateTime DataPedido { get; set; }

        public Pedido()
        {
            this.Id = 0;
            
            this.Nome_cliente = string.Empty;
            this.Telefone = string.Empty;
            this.Endereco = string.Empty;
            this.Observacoes = string.Empty;
            this.Sabor1 = string.Empty;
            this.Sabor2 = string.Empty;
            this.Sabor3 = string.Empty;
            this.Sabor4 = string.Empty;
            this.Tamanho = string.Empty; 
            this.DataPedido = DateTime.Now;

    }
    }
}
