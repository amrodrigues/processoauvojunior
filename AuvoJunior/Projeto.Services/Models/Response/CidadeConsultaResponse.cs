using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models.Response
{
    public class CidadeConsultaResponse
    {
        public int IdCidade { get; set; }
        public string Nome { get; set; }

        public int IdEstado { get; set; }

    }
}