using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Aplicacion.ManejadorError;
using FluentValidation;
using MediatR;
using Persistencia;

namespace Aplicacion.GrupoBD
{
    public class EditarGrupoBD_fs
    {
        public class Ejecuta : IRequest{
            public string Consulta { get; set; }
            public string DescripcionConsulta { get; set; }
            public string TipoBD { get; set; }
            public string VersionBD { get; set; }
            public string Entorno { get; set; }
            public DateTime UltimaModificacion { get; set; }
            public string UltimoUsuario { get; set; }
            public Guid ConsultaFSID { get; }
        }

        // Lógica de la validación incluida con FluentValidation
        public class EjecutaValidacion : AbstractValidator<Ejecuta>{
            public EjecutaValidacion(){
                RuleFor( x => x.Consulta).NotEmpty();
                RuleFor( x => x.DescripcionConsulta).NotEmpty();
                RuleFor( x => x.UltimaModificacion).NotEmpty();
                RuleFor( x => x.UltimoUsuario).NotEmpty();
            }
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly GrupoBD2_Context _context;
            public Manejador(GrupoBD2_Context context){
                _context = context;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var tblGrupoBD = await _context.TblGrupoBD_fs.FindAsync(request.Consulta);
                if(tblGrupoBD==null){
                    throw new ManejadorExcepcion(HttpStatusCode.NotFound, new {tabla_grupoBD_fs = "No se encontró este registro"});
                }

                // las ?? significan que si el valor no ha cambiado, no graba ese dato
                // Consulta no se modifica si se usa Postman y se incluye dentro de los {} ¿hay que retocar esta rutina más adelante?
                tblGrupoBD.Consulta = request.Consulta ?? tblGrupoBD.Consulta;
                tblGrupoBD.DescripcionConsulta = request.DescripcionConsulta ?? tblGrupoBD.DescripcionConsulta;
                tblGrupoBD.TipoBD = request.TipoBD ?? tblGrupoBD.TipoBD;
                tblGrupoBD.VersionBD = request.VersionBD ?? tblGrupoBD.VersionBD;
                tblGrupoBD.Entorno = request.Entorno ?? tblGrupoBD.Entorno;
                tblGrupoBD.UltimaModificacion = tblGrupoBD.UltimaModificacion ?? tblGrupoBD.UltimaModificacion;
                tblGrupoBD.UltimoUsuario = request.UltimoUsuario ?? tblGrupoBD.UltimoUsuario;

                var resultado = await _context.SaveChangesAsync();
                if(resultado>0)
                    return Unit.Value;
                
                throw new Exception ("No se han guardado los cambios");
            }
        }
    }
}