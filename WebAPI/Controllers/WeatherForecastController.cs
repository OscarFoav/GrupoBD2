using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persistencia;

namespace WebAPI.Controllers
{
    // http://localhost:5665/WeatherForecast

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly GrupoBD2_Context context;
        public WeatherForecastController(GrupoBD2_Context _context){
            this.context = _context;
        }

        [HttpGet]
        /*
        public IEnumerable<string> Get(){
            string[] nombres = new[] {"Alberto","David","Rodri","Fran","Óscar"};
            return nombres;
        }
        */
        public IEnumerable<TblGrupoBD_fs> Get(){
            return context.TblGrupoBD_fs.ToList();
        }
    }
}
