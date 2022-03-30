using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Repository.Mappings
{
    public class EstadoMap : EntityTypeConfiguration<Estado>
    {
        public EstadoMap()
        {
            ToTable("Estado");

            HasKey(e => e.IdEstado);

            Property(e => e.IdEstado)
                .HasColumnName("Id")
                .IsRequired();

            Property(e => e.Nome)
              .HasColumnName("Nome")
              .HasMaxLength(200)
              .IsRequired();

       
        }
    }
}