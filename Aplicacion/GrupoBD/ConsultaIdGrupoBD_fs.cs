using System;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Persistencia;

namespace Aplicacion.GrupoBD
{
    public class ConsultaIdGrupoBD_fs
    {
        
        public class ConsultaUnicaGrupoBD_fs : IRequest<TblGrupoBD_fs>{
            public string Consulta {get;set;}            
        }

        public class Manejador : IRequestHandler<ConsultaUnicaGrupoBD_fs, TblGrupoBD_fs>
        {
            private readonly GrupoBD2_Context _context;
            public Manejador(GrupoBD2_Context context)
            {
                _context = context;
            }            
                        
            public async Task<TblGrupoBD_fs> Handle(ConsultaUnicaGrupoBD_fs request, CancellationToken cancellationToken)
            {
                var consulta = await _context.TblGrupoBD_fs.FindAsync(request.Consulta);
                return consulta;
            }
        }
    }
}