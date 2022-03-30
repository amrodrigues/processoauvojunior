using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;

namespace Projeto.Business.Contracts
{
    public interface IEstadoBusiness : IBaseBusiness<Estado> 
    {
        List<Estado> ConsultarPorNome(string nome);
    }
}
