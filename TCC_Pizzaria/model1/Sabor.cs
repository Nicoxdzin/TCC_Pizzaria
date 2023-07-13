using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model1
{
    public class Sabor
    {
        public int Id { get; set; }
        public string SaborPizza { get; set; }

        public Sabor() {

            this.Id = 0;
            this.SaborPizza = string.Empty;
        }
    }
}
