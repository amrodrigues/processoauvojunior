using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using Projeto.Business.Contracts;
using Projeto.Repository.Contracts;


namespace Projeto.Business
{
   public class EstadoBusiness : BaseBusiness<Estado>, IEstadoBusiness
    {
        private IEstadoRepository repository;

        public EstadoBusiness(IEstadoRepository repository) : base(repository)
        {
            this.repository = repository;
        }
        public List<Estado> ConsultarPorNome(string nome)
        {
            return repository.FindByNome(nome);
        }
    }

}