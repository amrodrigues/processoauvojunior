using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Repository.Mappings
{
   public class CidadeMap : EntityTypeConfiguration<Cidade>
    {
        public CidadeMap()
        {
            ToTable("Cidade");

            HasKey(c => c.IdCidade);

            Property(c => c.IdCidade)
                .HasColumnName("Id")
                .IsRequired();

            Property(c => c.Nome)
              .HasColumnName("Nome")
              .HasMaxLength(200)
              .IsRequired();

            Property(c => c.IdEstado)
            .HasColumnName("EstadoId")
            .IsRequired();

        }
    }
}
