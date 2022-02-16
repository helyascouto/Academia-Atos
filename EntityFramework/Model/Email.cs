using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Model
{
    public class Email
    {
        public int Id { get; set; }
        public string email { get; set; }
        public Pessoa pessoa { get; set; }
    }
}
