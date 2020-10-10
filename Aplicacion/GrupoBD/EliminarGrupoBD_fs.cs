using System;
using System.Threading;
using System.Threading.Tasks;
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
                var consulta = await  _context.TblGrupoBD_fs.FindAsync(request.Consulta);
                if(consulta==null){
                    throw new Exception("No se puede eliminar la fila");
                }
                
                _context.Remove(consulta);
                var resultado = await _context.SaveChangesAsync();

                if(resultado>0){
                    return Unit.Value;
                }

                throw new Exception("No se ha podido guardar los cambios");

            }
        }
    }
}