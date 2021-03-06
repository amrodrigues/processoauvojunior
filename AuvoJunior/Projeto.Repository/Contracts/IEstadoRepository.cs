using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;

namespace Projeto.Repository.Contracts
{
    public interface IEstadoRepository : IBaseRepository<Estado>
    {
        List<Estado> FindByNome(string nome);
    }
}
