using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.GrupoBD
{
    public class ConsultaGrupoBD_fs
    {
        public class ListaConsultas : IRequest<List<TblGrupoBD_fs>> {}

        public class Manejador : IRequestHandler<ListaConsultas, List<TblGrupoBD_fs>>
        {

            private readonly GrupoBD2_Context _context;
            public Manejador(GrupoBD2_Context context){
                _context = context;
            }
            public async Task<List<TblGrupoBD_fs>> Handle(ListaConsultas request, CancellationToken cancellationToken)
            {
                var consultas = await _context.TblGrupoBD_fs.ToListAsync();
                return consultas; 
            }
        }
    }
}