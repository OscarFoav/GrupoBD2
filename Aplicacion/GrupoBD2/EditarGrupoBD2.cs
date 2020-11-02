using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Persistencia.DapperConexion.GrupoBD2;

namespace Aplicacion.GrupoBD2
{
      public class EditarGrupoBD2
      {
            public class Ejecuta : IRequest
            {
                  public string Consulta { get; set; }
                  public Guid ConsultaFSID { get; set; }
                  public string DescripcionConsulta { get; set; }
                  public string TipoBD { get; set; }
                  public string VersionBD { get; set; }
                  public string Entorno { get; set; }
                  public DateTime UltimaModificacion { get; set; }
                  public string UltimoUsuario { get; set; }
            }

            public class EjecutaValida : AbstractValidator<Ejecuta>
            {
                  public EjecutaValida()
                  {
                        RuleFor(x => x.Consulta).NotEmpty();
                        RuleFor(x => x.DescripcionConsulta).NotEmpty();
                        RuleFor(x => x.UltimoUsuario).NotEmpty();
                  }
            }

            public class Manejador : IRequestHandler<Ejecuta>
            {
                  private readonly IGrupoBD2 _grupoBD2Repositorio;
                  public Manejador(IGrupoBD2 grupoBD2Repositorio){
                      _grupoBD2Repositorio = grupoBD2Repositorio;
                  }
                  public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
                  {
                    var resultado = await _grupoBD2Repositorio.ActualizaGrupoBD2(request.Consulta, request.ConsultaFSID,
                                                            request.DescripcionConsulta,
                                                            request.TipoBD, request.VersionBD, request.Entorno, 
                                                            request.UltimaModificacion, request.UltimoUsuario);
                    if (resultado > 0){
                        return Unit.Value;
                    }

                    throw new Exception ("No se ha podido actualizar el registro");
                  }
            }
      }
}