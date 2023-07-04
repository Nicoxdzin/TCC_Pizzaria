using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model1
{
    public class Admin
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; } 
        public string CPF { get; set; }  
        public string Senha { get; set; }     
        public DateTime DataCadastro { get; set; }
        public bool logado { get; set; }



        public Admin() {

            this.Id = 0;
       
            this.Nome = string.Empty;
            this.Sobrenome = string.Empty;
            this.CPF = string.Empty;
            this.Senha = string.Empty;
            this.DataCadastro = DateTime.Now;
            this.logado = false;

        }


    }
}
