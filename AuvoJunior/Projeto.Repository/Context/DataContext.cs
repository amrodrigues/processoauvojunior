using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Entities;
using Projeto.Repository.Mappings;
using System.Configuration;


namespace Projeto.Repository.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base(ConfigurationManager.ConnectionStrings["auvojunior"].ConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CidadeMap());
         modelBuilder.Configurations.Add(new EstadoMap());
          modelBuilder.Configurations.Add(new PrevisaoClimaMap());
        }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Estado> Estado { get; set; }
       public DbSet<PrevisaoClima> PrevisaoClima { get; set;  }
        
    }
}
