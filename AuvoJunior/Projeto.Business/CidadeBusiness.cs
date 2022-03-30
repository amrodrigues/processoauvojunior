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
    public class CidadeBusiness : BaseBusiness<Cidade>, ICidadeBusiness
    {
        private ICidadeRepository repository;

        public CidadeBusiness(ICidadeRepository repository): base(repository)
            {
            this.repository = repository;
            }
        public List<Cidade> ConsultarPorNome(string nome)
        {
            return repository.FindByNome(nome);
        }
    }

}