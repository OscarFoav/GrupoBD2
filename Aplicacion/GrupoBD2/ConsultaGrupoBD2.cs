using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistencia.DapperConexion.GrupoBD2;

namespace Aplicacion.GrupoBD2
{
    public class ConsultaGrupoBD2
    {
        public class Lista : IRequest<List<GrupoBD2Model>> {
                  public class Manejador : IRequestHandler<Lista, List<GrupoBD2Model>>
                  {
                      private readonly IGrupoBD2 _grupoBD2Repository;
                      public Manejador(IGrupoBD2 grupoBD2Repository){
                          _grupoBD2Repository = grupoBD2Repository;
                      }
                        public async Task<List<GrupoBD2Model>> Handle(Lista request, CancellationToken cancellationToken)
                        {
                            var resultado = await _grupoBD2Repository.ObtenerLista();
                            return resultado.ToList();
                        }
                  }
            }
    }
}