using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistencia.DapperConexion.GrupoBD2;
using Aplicacion.GrupoBD2;
namespace WebAPI.Controllers
{
    public class GrupoBD2Controller : MiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GrupoBD2Model>>> ObtenerGrupoBD2(){
            return await Mediator.Send(new ConsultaGrupoBD2.Lista());
        }
    }
}