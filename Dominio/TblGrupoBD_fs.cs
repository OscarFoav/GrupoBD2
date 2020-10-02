using System;

namespace Dominio
{
    public class TblGrupoBD_fs
    {
        public Guid ConsultaFSID { get; set; }
        public string Consulta { get; set; }
        public string DescripcionConsulta { get; set; }
        public string TipoBD { get; set; }
        public string Entorno { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public string UltimoUsuario { get; set; }

    }
}