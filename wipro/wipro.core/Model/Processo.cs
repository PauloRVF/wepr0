using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wepr0.core.Model
{
    public class Processo
    {
        public int Id { get; set; }
        public virtual Moeda Moeda { get; set; }
        public int MoedaId { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fim { get; set; }
    }
}
