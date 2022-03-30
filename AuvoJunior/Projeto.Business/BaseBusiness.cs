using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Business.Contracts;
using Projeto.Repository.Contracts;

namespace Projeto.Business
{
    public abstract class BaseBusiness<T> : IBaseBusiness<T> where T : class
    {
        private IBaseRepository<T> repository;
      //  private IPrevisaoClimaRepository repository1;

        public BaseBusiness(IBaseRepository<T> repository)
        {
            this.repository = repository;
        }

   //     protected BaseBusiness(IPrevisaoClimaRepository repository1)
   //     {
   //         this.repository1 = repository1;
  //      }

        public virtual void Atualizar(T obj)
        {
            repository.Update(obj);
        }

        public virtual void Cadastrar(T obj)
        {
            repository.Insert(obj);
        }

        public virtual T ConsultarPorId(int id)
        {
            return repository.FindById(id);
        }

        public virtual List<T> ConsultarTodos()
        {
         return   repository.FindAll();
        }

        public virtual void Excluir(T obj)
        {
            repository.Delete(obj);
        }
        
    }
}
