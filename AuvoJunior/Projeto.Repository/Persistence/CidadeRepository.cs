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
    public class CidadeRepository : BaseRepository<CidadeRepository>, ICidadeRepository
    {
        public void Delete(Cidade obj)
        {
            throw new NotImplementedException();
        }

   //     public List<Cidade> FindByNome(string nome)
   //     {
   //         throw new NotImplementedException();
    //    }

        public List<Cidade> FindByNome(string nome)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Cidade
                        .Where(c => c.Nome.Contains(nome))
                        .OrderBy(c => c.Nome)
                        .ToList();
            }
        }

        List<Cidade> IBaseRepository<Cidade>.FindAll()
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Cidade
                        
                        .ToList();
            }
        }

        public void Insert(Cidade obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Cidade obj)
        {
            throw new NotImplementedException();
        }

    

        Cidade IBaseRepository<Cidade>.FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
