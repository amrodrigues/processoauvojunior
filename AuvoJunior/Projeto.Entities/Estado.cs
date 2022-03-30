using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Estado

    {
        public int IdEstado { get; set; }

        public string Nome { get; set; }

        public String Uf { get; set; }

        public Estado()
        { }

        public Estado( int idEstado , string nome, string uf)
        {
            IdEstado = idEstado;
            Nome = nome;
            Uf = uf;
        }
    }
}
