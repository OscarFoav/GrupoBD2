using System;

namespace Dominio
{
    public class TblServidoresSQLServer
    {
        public string CompleteName { get; set; }
        public string MachineName { get; set; }
        public string NetbiosName { get; set; }
        public string InstanceName { get; set; }
        public string LocalSQLServerPort { get; set; }
        public string Edition { get; set; }
        public string EditionID { get; set; }
        public string EngineEdition { get; set; }
        public string Collation { get; set; }
        public string FullTextInstalled { get; set; }
        public string HadrManagerStatus { get; set; }
        public string IntegratedSecurityOnly { get; set; }
        public string ProductVersion { get; set; }
        public string ProductLevel { get; set; }
        public string IsClustered { get; set; }
        public string SqlCharSetName { get; set; }
        public string DataBaseCreationDate { get; set; }
        public string SizeDB { get; set; }
        public string ErrorLog { get; set; }
        public string UmbralMonitorizacionRows { get; set; }
        public string UmbralMonitorizacionLog { get; set; }
        public string ListaBBDD { get; set; }
        public string Comentario { get; set; }
    }
}