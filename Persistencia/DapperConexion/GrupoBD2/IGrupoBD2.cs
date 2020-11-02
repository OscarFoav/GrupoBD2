using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistencia.DapperConexion.GrupoBD2
{
    public interface IGrupoBD2
    {
         Task<IEnumerable<GrupoBD2Model>> ObtenerLista();

         Task<IEnumerable<GrupoBD2Model>> ObtenerListaSinDescripcionConsulta();

         Task<GrupoBD2Model> ObtenerPorConsulta(string consulta);

         Task<int> NuevoGrupoBD2(GrupoBD2Model parametros);

         Task<int> ActualizaGrupoBD2(GrupoBD2Model parametros);

         Task<int> EliminaGrupoBD2(string consulta);
    }
}