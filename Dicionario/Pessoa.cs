using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicionario
{
    class Pessoa
    {
        private string v;

        public Pessoa(string v)
        {
            this.v = v;
        }

        public string nome { get; set; }
    }
}
