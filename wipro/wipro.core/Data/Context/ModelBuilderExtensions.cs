using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wipro.core.Model;

namespace wipro.core.Data.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Moeda>()
                .HasData(
                new Moeda { Id = 1, Simbolo = "USD" },
                new Moeda { Id = 2, Simbolo = "PGK" },
                new Moeda { Id = 3, Simbolo = "ARS" },
                new Moeda { Id = 4, Simbolo = "LSL" },
                new Moeda { Id = 5, Simbolo = "RON" },
                new Moeda { Id = 6, Simbolo = "AWG" },
                new Moeda { Id = 7, Simbolo = "MUR" },
                new Moeda { Id = 8, Simbolo = "CUP" },
                new Moeda { Id = 9, Simbolo = "JPY" },
                new Moeda { Id = 10, Simbolo = "SLL" },
                new Moeda { Id = 11, Simbolo = "ISK" },
                new Moeda { Id = 12, Simbolo = "EGP" },
                new Moeda { Id = 13, Simbolo = "TRY" },
                new Moeda { Id = 14, Simbolo = "XOF" },
                new Moeda { Id = 15, Simbolo = "MRU" },
                new Moeda { Id = 16, Simbolo = "CLP" },
                new Moeda { Id = 17, Simbolo = "IRR" },
                new Moeda { Id = 18, Simbolo = "GIP" },
                new Moeda { Id = 19, Simbolo = "KMF" },
                new Moeda { Id = 20, Simbolo = "EUR" },
                new Moeda { Id = 21, Simbolo = "KES" },
                new Moeda { Id = 22, Simbolo = "GBP" },
                new Moeda { Id = 23, Simbolo = "NIO" },
                new Moeda { Id = 24, Simbolo = "PHP" },
                new Moeda { Id = 25, Simbolo = "CAD" },
                new Moeda { Id = 26, Simbolo = "MGB" },
                new Moeda { Id = 27, Simbolo = "XDR" },
                new Moeda { Id = 28, Simbolo = "WST" },
                new Moeda { Id = 29, Simbolo = "CZK" },
                new Moeda { Id = 30, Simbolo = "XAF" },
                new Moeda { Id = 31, Simbolo = "ZWL" },
                new Moeda { Id = 32, Simbolo = "SBD" },
                new Moeda { Id = 33, Simbolo = "ANG" },
                new Moeda { Id = 34, Simbolo = "OMR" },
                new Moeda { Id = 35, Simbolo = "MGA" },
                new Moeda { Id = 36, Simbolo = "DJF" },
                new Moeda { Id = 37, Simbolo = "COP" },
                new Moeda { Id = 38, Simbolo = "FJD" },
                new Moeda { Id = 39, Simbolo = "THB" },
                new Moeda { Id = 40, Simbolo = "ILS" },
                new Moeda { Id = 41, Simbolo = "MXN" },
                new Moeda { Id = 42, Simbolo = "LBP" },
                new Moeda { Id = 43, Simbolo = "MZN" },
                new Moeda { Id = 44, Simbolo = "SAR" },
                new Moeda { Id = 45, Simbolo = "PEN" },
                new Moeda { Id = 46, Simbolo = "UYU" },
                new Moeda { Id = 47, Simbolo = "SSP" },
                new Moeda { Id = 48, Simbolo = "GEL" },
                new Moeda { Id = 49, Simbolo = "ALL" },
                new Moeda { Id = 50, Simbolo = "XPF" },
                new Moeda { Id = 51, Simbolo = "CVE" },
                new Moeda { Id = 52, Simbolo = "CRC" },
                new Moeda { Id = 53, Simbolo = "MRO" },
                new Moeda { Id = 54, Simbolo = "DZD" },
                new Moeda { Id = 55, Simbolo = "SZL" },
                new Moeda { Id = 56, Simbolo = "BOB" },
                new Moeda { Id = 57, Simbolo = "VUV" },
                new Moeda { Id = 58, Simbolo = "CDF" },
                new Moeda { Id = 59, Simbolo = "UGX" },
                new Moeda { Id = 60, Simbolo = "XAU" },
                new Moeda { Id = 61, Simbolo = "SOS" },
                new Moeda { Id = 62, Simbolo = "NOK" },
                new Moeda { Id = 63, Simbolo = "HTG" },
                new Moeda { Id = 64, Simbolo = "BYN" },
                new Moeda { Id = 65, Simbolo = "ZAR" },
                new Moeda { Id = 66, Simbolo = "AFN" },
                new Moeda { Id = 67, Simbolo = "TTD" },
                new Moeda { Id = 68, Simbolo = "VES" },
                new Moeda { Id = 69, Simbolo = "MMK" },
                new Moeda { Id = 70, Simbolo = "SGD" }
                );
        }
    }
}
