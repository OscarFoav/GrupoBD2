using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistencia.DapperConexion.GrupoBD2
{
    public interface IGrupoBD2
    {
         Task<IEnumerable<GrupoBD2Model>> ObtenerLista();

         Task<IEnumerable<GrupoBD2Model_SinDescripcion>> ObtenerGrupoBD2_SinDescripcion();

         Task<GrupoBD2Model> ObtenerPorConsulta(string consulta);

         Task<int> NuevoGrupoBD2(string Consulta, Guid ConsultaFSID,
                                    string DescripcionConsulta, string TipoBD,
                                    string VersionBD, string Entorno, 
                                    DateTime UltimaModificacion, string UltimoUsuario);

         Task<int> ActualizaGrupoBD2(string Consulta, Guid ConsultaFSID,
                                    string DescripcionConsulta, string TipoBD,
                                    string VersionBD, string Entorno, 
                                    DateTime UltimaModificacion, string UltimoUsuario);

         Task<int> EliminaGrupoBD2(string consulta);
    }
}