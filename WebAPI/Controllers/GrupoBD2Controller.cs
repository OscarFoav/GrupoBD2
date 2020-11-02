using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistencia.DapperConexion.GrupoBD2;
using Aplicacion.GrupoBD2;
using System;

namespace WebAPI.Controllers
{
      public class GrupoBD2Controller : MiControllerBase
      {
            [HttpGet]
            public async Task<ActionResult<List<GrupoBD2Model>>> ObtenerGrupoBD2()
            {
                  return await Mediator.Send(new ConsultaGrupoBD2.Lista());
            }

            // http://localhost:5665/api/GrupoBD2/sinDescripcion
            [HttpGet("sinDescripcion")]
            public async Task<ActionResult<List<GrupoBD2Model_SinDescripcion>>> ObtenerGrupoBD2_SinDescripcion(int sinDescripcion){
                  return await Mediator.Send(new ConsultaGrupoBD2_SinDescripcion.Lista());
            }

            [HttpPost]
            public async Task<ActionResult<Unit>> CrearGrupoBD2(NuevoGrupoBD2.Ejecuta data)
            {
                return await Mediator.Send(data);
            }

            [HttpPut("{ConsultaFSID}")]
            public async Task<ActionResult<Unit>> Actualizar(Guid ConsultaFSID, EditarGrupoBD2.Ejecuta data){
                  data.ConsultaFSID = ConsultaFSID;
                  return await Mediator.Send(data);
            }
      }
}