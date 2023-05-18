using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model1
{
    public class Cliente
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string numero_tel { get; set; }
        public string cep { get; set; }
        public string numero_casa { get; set; }
        public string referencia { get; set; }

        public Cliente()
        {
            this.Id = 0;
            this.nome = string.Empty;
            this.cpf = string.Empty;
            this.numero_tel = string.Empty;
            this.cep = string.Empty;
            this.numero_casa = string.Empty;
            this.referencia = string.Empty;

        }

    }
}
