using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Aplicacion.ManejadorError;
using MediatR;
using Persistencia;

namespace Aplicacion.GrupoBD
{
    public class EliminarGrupoBD_fs
    {
        public class Ejecuta : IRequest {
            public string Consulta {get;set;}
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly GrupoBD2_Context _context;
            public Manejador(GrupoBD2_Context context){
                _context = context;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var tblGrupoBD = await  _context.TblGrupoBD_fs.FindAsync(request.Consulta);
                if(tblGrupoBD==null){
                    throw new ManejadorExcepcion(HttpStatusCode.NotFound, new {tabla_grupoBD_fs = "No se encontró este registro"});
                    // throw new Exception("No se puede eliminar la fila");
                }
                
                _context.Remove(tblGrupoBD);
                var resultado = await _context.SaveChangesAsync();

                if(resultado>0){
                    return Unit.Value;
                }

                throw new Exception("No se ha podido guardar los cambios");

            }
        }
    }
}