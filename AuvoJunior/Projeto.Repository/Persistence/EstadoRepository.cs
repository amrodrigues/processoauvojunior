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
    public class EstadoRepository : BaseRepository<EstadoRepository>, IEstadoRepository
    {
        public void Delete(Estado obj)
        {
            throw new NotImplementedException();
        }

        public List<Estado> FindByNome(string nome)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Estado
                        .Where(c => c.Nome.Contains(nome))
                        .OrderBy(c => c.Nome)
                        .ToList();
            }
        }



        List<Estado> IBaseRepository<Estado>.FindAll()
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Estado
                        .ToList();
            }
        }

        public void Insert(Estado obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Estado obj)
        {
            throw new NotImplementedException();
        }

        Estado IBaseRepository<Estado>.FindById(int id)
        {
            throw new NotImplementedException();
        }
    }

}
