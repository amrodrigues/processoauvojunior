using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Repository.Contracts;
using Projeto.Repository.Context;

namespace Projeto.Repository.Persistence
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public void Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public List<T> FindAll()
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Set<T>().ToList();
            }
        }

        public T FindById(int id)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Set<T>().Find(id);
            }
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
