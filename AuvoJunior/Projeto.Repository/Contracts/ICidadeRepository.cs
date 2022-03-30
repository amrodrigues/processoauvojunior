using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;

namespace Projeto.Repository.Contracts
{
    public interface ICidadeRepository : IBaseRepository<Cidade>
    {
        List<Cidade> FindByNome(string nome);
    }
}
