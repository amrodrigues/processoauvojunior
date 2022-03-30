using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models.Response
{
    public class PrevisaoClimaConsultaResponse
    {
        public int IdPrevisaoClima { get; set; }
        public int IdCidade { get; set; }
        public DateTime DataPrevisao { get; set; }
        public string Clima { get; set; }
        public decimal TemperaturaMinima { get; set; }
        public decimal TemperaturaMaxima { get; set; }

    }
}