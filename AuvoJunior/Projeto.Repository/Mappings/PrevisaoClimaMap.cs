using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Repository.Mappings
{
    public class PrevisaoClimaMap : EntityTypeConfiguration<PrevisaoClima>
    {
        public PrevisaoClimaMap()
        {
            ToTable("PrevisaoClima");

            HasKey(p => p.IdPrevisaoClima);

            Property(p => p.IdPrevisaoClima)
                .HasColumnName("Id")
                .IsRequired();

            Property(p => p.IdCidade)
              .HasColumnName("CidadeId")
              .IsRequired()
              ;

      //      HasRequired(p => p.Cidade)
        //        .WithMany(c=> c.IdCidade)
          //      .HasForeignKey(prop => p.idCidade);
            
            Property(p => p.DataPrevisao)
                .HasColumnName("DataPrevisao")
                .IsRequired();

            Property(p=> p.Clima)
            .HasColumnName("Clima")
            .HasMaxLength(50)
            .IsRequired();

            Property(p => p.TemperaturaMinima)
                .HasColumnName("TemperaturaMinima")
                .IsRequired();


            Property(p => p.TemperaturaMaxima)
                .HasColumnName("TemperaturaMaxima")
                .IsRequired();
        }
    }
}
