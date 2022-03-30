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
    [RoutePrefix("api/estado")]
    public class EstadoController : ApiController
    {
        private IEstadoBusiness business;
        private object response;

        public EstadoController(IEstadoBusiness business)
        {
            this.business = business;
        }

        [Route("consultar")]
        [HttpGet]
        public HttpResponseMessage ConsultarTodos()
        {
            List<EstadoConsultaResponse> lista = new List<EstadoConsultaResponse>();

            try
            {
                foreach (Estado c in business.ConsultarTodos())
                {
                    EstadoConsultaResponse response = new EstadoConsultaResponse();
                    response.IdEstado = c.IdEstado;
                    response.Nome = c.Nome;
                    response.Uf = c.Uf;

                    lista.Add(response);
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