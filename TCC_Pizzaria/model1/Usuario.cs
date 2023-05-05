using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model1
{
    public class Usuario
    {
        //private string nome_usuario { get; set; }
        public int codigo { get; set; }
        public int perfil { get; set; }
        public string nome { get; set; }
        public string email{ get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public bool logado { get; set; }


        public Usuario()
        {
            this.codigo = 0;
            this.nome = "";
            this.email = "";
            this.usuario = string.Empty;
            this.senha = string.Empty;
            this.logado = false;
        }

    }
}
