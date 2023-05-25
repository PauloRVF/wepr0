using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CsvHelper.Configuration.Attributes;

namespace wepr0.core.DTO
{
    public class DadosMoedaDTO
    {
        [Name("ID_MOEDA")]
        public string Id_Moeda { get; set; }
        [Name("DATA_REF")]
        public DateTime Data_Ref { get; set; }
        [Name("VLR_COTACAO")]
        public Double Vlr_Cotacao { get; set; }
    }
}
