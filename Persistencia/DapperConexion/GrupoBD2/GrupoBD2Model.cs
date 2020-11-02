using System;

namespace Persistencia.DapperConexion.GrupoBD2
{
      public class GrupoBD2Model
      {
            public string Consulta { get; set; }
            public Guid ConsultaFSID { get; set; }
            public string DescripcionConsulta { get; set; }
            public string TipoBD { get; set; }
            public string VersionBD { get; set; }
            public string Entorno { get; set; }
            public string UltimaModificacion { get; set; }
            public string UltimoUsuario { get; set; }
      }
}