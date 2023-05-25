using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wepr0.core.Model
{
    public class Cotacao
    {
        public int Id { get; set; }
        public Moeda Moeda { get; set; }
        public Double Valor_Cotacao { get; set; }
        public DateTime Data_Cotacao { get; set; }
    }
}
