using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero.Models
{
    public class Client
    {
        public int ID { get; set; }
        public int Pass { get; set; }
        public string Number { get; set; }
        public double Saldo { get; set; }
    }
}
