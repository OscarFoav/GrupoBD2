using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.GrupoBD;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    // http://localhost:5665/api/GrupoBD2
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoBD2Controller : MiControllerBase
    {
        

        [HttpGet]        
        public async Task<ActionResult<List<TblGrupoBD_fs>>> Get()
        {
            return await Mediator.Send(new ConsultaGrupoBD_fs.ListaConsultas());
        }

        // http://localhost:5665/api/GrupoBD2/Acceso a Check_MK
        [HttpGet("{consulta}")]
        public async Task<ActionResult<TblGrupoBD_fs>> Detalle(string consulta)
        {
            return await Mediator.Send(new ConsultaIdGrupoBD_fs.ConsultaUnicaGrupoBD_fs{ Consulta = consulta });
        }

        // http://localhost:5665/api/GrupoBD2/Consulta 3
        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(NuevoGrupoBD_fs.Ejecuta data){
            return await Mediator.Send(data);
        }

        [HttpPut("{Consulta}")]
        public async Task<ActionResult<Unit>> Editar(string consulta, EditarGrupoBD_fs.Ejecuta data){
            data.Consulta = consulta;
            return await Mediator.Send(data);
        }

        [HttpDelete("{consulta}")]
        public async Task<ActionResult<Unit>> Eliminar(string consulta){
            return await Mediator.Send(new EliminarGrupoBD_fs.Ejecuta{Consulta = consulta});
        }

    }
}