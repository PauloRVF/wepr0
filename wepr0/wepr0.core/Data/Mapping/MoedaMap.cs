﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wepr0.core.Model;

namespace Wepr0.core.Data.Mapping
{
    public class MoedaMap : IEntityTypeConfiguration<Moeda>
    {
        public void Configure(EntityTypeBuilder<Moeda> builder)
        {
            builder.ToTable("Moeda");
            builder.Property(m => m.Id).IsRequired();
            builder.Property(m => m.Simbolo).IsRequired().HasMaxLength(3).HasColumnType("varchar");
        }
    }
}
