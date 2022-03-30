using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Repository.Contracts;
using Projeto.Repository.Context;
using Projeto.Entities;

namespace Projeto.Repository.Persistence
{
    public class PrevisaoClimaRepository : BaseRepository<PrevisaoClimaRepository>, IPrevisaoClimaRepository
    {
        public void Delete(PrevisaoClima obj)
        {
            throw new NotImplementedException();
        }

        public List<PrevisaoClima> FindByNome(string nome)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.PrevisaoClima
                        .Where(c => c.Clima.Contains(nome))
                        .OrderBy(c => c.Clima)
                        .ToList();
            }
        }

        public void Insert(PrevisaoClima obj)
        {
            throw new NotImplementedException();
        }

        public void Update(PrevisaoClima obj)
        {
            throw new NotImplementedException();
        }

        List<PrevisaoClima> IBaseRepository<PrevisaoClima>.FindAll()
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.PrevisaoClima
                        .ToList();
            }
        }

        PrevisaoClima IBaseRepository<PrevisaoClima>.FindById(int id)
        {
            throw new NotImplementedException();
        }
    }

}
