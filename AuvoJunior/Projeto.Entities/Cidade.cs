using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Cidade
    {
        public int IdCidade { get; set; }
        public string Nome { get; set; }

        public int IdEstado { get; set; }

        public Estado Estado { get; set; }

        public Cidade()
        { }

        public Cidade (int idCidade , string nome , int idEstado)
        {
            IdCidade = idCidade;
            Nome = nome;
            IdEstado = idEstado;
        }
}
}
