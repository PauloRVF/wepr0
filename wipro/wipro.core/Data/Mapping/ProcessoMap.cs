using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wipro.core.Model;

namespace wipro.core.Data.Mapping
{
    public class ProcessoMap : IEntityTypeConfiguration<Processo>
    {
        public void Configure(EntityTypeBuilder<Processo> builder)
        {
            builder.ToTable("Processos");
            builder.Property(p => p.Id).IsRequired();            
            builder.Property(p => p.Data_Inicio).IsRequired().HasColumnType("datetime");
            builder.Property(p => p.Data_Fim).IsRequired().HasColumnType("datetime");
        }
    }
}
