using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class PrevisaoClima
    {
        public int IdPrevisaoClima { get; set; }
        public int IdCidade { get; set; }

        public Cidade Cidade { get; set; }
        public DateTime DataPrevisao { get; set; }
        public string Clima { get; set; }
        public decimal TemperaturaMinima { get; set; }
        public decimal TemperaturaMaxima { get; set; }

        public PrevisaoClima()
        { }

        public PrevisaoClima(int idPrevisaoClima, int idCidade, DateTime dataPrevisao, string clima, decimal temperaturaMinima, decimal temperaturaMaxima)
        {
            IdPrevisaoClima = idPrevisaoClima;
            IdCidade = idCidade;
            DataPrevisao = dataPrevisao;
            Clima = clima;
            TemperaturaMaxima = temperaturaMaxima;
            TemperaturaMinima = temperaturaMinima;

        }
    }
}