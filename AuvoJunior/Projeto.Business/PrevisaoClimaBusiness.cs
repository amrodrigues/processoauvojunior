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
    public class PrevisaoClimaBusiness : BaseBusiness<PrevisaoClima>, IPrevisaoClimaBusiness
    {
        private IPrevisaoClimaRepository repository;

        public PrevisaoClimaBusiness(IPrevisaoClimaRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public List<PrevisaoClima> ConsultarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

      
    }
}
