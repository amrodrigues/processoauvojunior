using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Net.Http;
using Projeto.Services.Models.Response;
using Projeto.Entities;
using Projeto.Business.Contracts;
using System.Web.Http.ModelBinding;

namespace Projeto.Services.Controllers
{
    [RoutePrefix("api/previsaoclima")]

    public class PrevisaoClimaController : ApiController
    {
        private IPrevisaoClimaBusiness business;
        private object response;
        public PrevisaoClimaController(IPrevisaoClimaBusiness business)
        {
            this.business = business;
        }

        [Route("consultar")]
        [HttpGet]
        public HttpResponseMessage ConsultarTodos()
        {
            List<PrevisaoClimaConsultaResponse> lista = new List<PrevisaoClimaConsultaResponse>();

            try
            {
                foreach (PrevisaoClima c in business.ConsultarTodos())
                {
                    PrevisaoClimaConsultaResponse response = new PrevisaoClimaConsultaResponse();
                    response.IdPrevisaoClima = c.IdPrevisaoClima;
                    response.IdCidade = c.IdCidade;
                    response.Clima = c.Clima;
                    response.TemperaturaMaxima = c.TemperaturaMaxima;
                    response.TemperaturaMinima = c.TemperaturaMinima;
                    response.DataPrevisao = c.DataPrevisao;

                    DateTime data1 = Convert.ToDateTime(c.DataPrevisao).Date;
                    DateTime data2 = Convert.ToDateTime(DateTime.Now).Date;

                    int resultado = DateTime.Compare(data1, data2);

                    if (resultado >= 0)
                    {
                        lista.Add(response);
                    }
                }

                return Request.CreateResponse(HttpStatusCode.OK, lista);
            }
            catch (Exception e)
            {
                response = e.Message;

                return Request.CreateResponse(HttpStatusCode.BadRequest, lista);
            }

        }



       
    }
}