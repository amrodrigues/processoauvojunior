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
    [RoutePrefix("api/cidade")]
    public class CidadeController : ApiController
    {
        private ICidadeBusiness business;
        private object response;

        public CidadeController(ICidadeBusiness business)
        {
            this.business = business;
        }
    
        [Route("consultar")]
        [HttpGet]
        public HttpResponseMessage ConsultarTodos()
            {
            List<CidadeConsultaResponse> lista = new List<CidadeConsultaResponse>();

            try 
            { 
                foreach(Cidade c in business.ConsultarTodos())
                {
                    CidadeConsultaResponse response = new CidadeConsultaResponse();
                    response.IdCidade = c.IdCidade;
                    response.Nome = c.Nome;
                    response.IdEstado = c.IdEstado;

                    lista.Add(response);
                }

                return Request.CreateResponse(HttpStatusCode.OK, lista);
            }
            catch(Exception e)
            {
                response = e.Message;

                return Request.CreateResponse(HttpStatusCode.BadRequest, lista);
            }

         }




    }
}