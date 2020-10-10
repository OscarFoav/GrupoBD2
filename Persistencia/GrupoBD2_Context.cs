using Dominio;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class GrupoBD2_Context : IdentityDbContext<Usuario>
    {
        public GrupoBD2_Context(DbContextOptions options) : base(options){
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            // esta línea generará las tablas en la base de datos GrupoBD2 de forma automática
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TblGrupoBD_fs>().HasKey (ci => new{ci.Consulta});
            modelBuilder.Entity<TblDestinoSSIS_GRID12>().HasKey (ci => new{ci.INSTANCE});
            modelBuilder.Entity<TblServidoresSQLServer>().HasKey (ci => new{ci.CompleteName});
        }

        public DbSet<TblGrupoBD_fs> TblGrupoBD_fs {get;set;}
        public DbSet<TblDestinoSSIS_GRID12> TblServidoresOracle_GRID12 {get;set;}
        public DbSet<TblServidoresSQLServer> tblServidoresSQLServer_BBDD {get;set;}
    }
}