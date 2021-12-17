using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialização
{
    [Serializable]
    public class Pessoa
    {
        public string nome;
        public int idade;
       // [XmlIgnore]
        public float salario;
    }
}

