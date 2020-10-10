using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using FluentValidation;
using MediatR;
using Persistencia;

namespace Aplicacion.GrupoBD
{
    public class NuevoGrupoBD_fs
    {
        public class Ejecuta : IRequest
        {
            public Guid ConsultaFSID { get; set; }
            public string Consulta { get; set; }
            public string DescripcionConsulta { get; set; }
            public string TipoBD { get; set; }
            public string VersionBD {get;set;}
            public string Entorno { get; set; }
            public DateTime UltimaModificacion { get; set; }
            public string UltimoUsuario { get; set; }
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
                var tblGrupoBD = new TblGrupoBD_fs {
                    Consulta = request.Consulta,
                    DescripcionConsulta = request.DescripcionConsulta,
                    TipoBD = request.TipoBD,
                    VersionBD = request.VersionBD,
                    Entorno = request.Entorno,
                    UltimaModificacion = request.UltimaModificacion,
                    UltimoUsuario = request.UltimoUsuario
                };

                _context.TblGrupoBD_fs.Add(tblGrupoBD);
                var respuesta = await _context.SaveChangesAsync();
                if(respuesta>0){
                    // se graban datos
                    return Unit.Value;
                }

                throw new Exception("No se insertó ningún dato");
            }
        }
    }
}