using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.GrupoBD;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    // http://localhost:5665/api/GrupoBD2
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoBD2Controller : ControllerBase
    {
        private readonly IMediator _mediator;
        public GrupoBD2Controller(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<TblGrupoBD_fs>>> Get()
        {
            return await _mediator.Send(new ConsultaGrupoBD_fs.ListaConsultas());
        }

        // http://localhost:5665/api/GrupoBD2/Acceso a Check_MK
        [HttpGet("{Consulta}")]
        public async Task<ActionResult<TblGrupoBD_fs>> Detalle(string Consulta)
        {
            return await _mediator.Send(new ConsultaIdGrupoBD_fs.ConsultaUnicaGrupoBD_fs{ Id = Consulta });
        }
    }
}