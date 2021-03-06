﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(GrupoBD2_Context))]
    partial class GrupoBD2_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominio.TblDestinoSSIS_GRID12", b =>
                {
                    b.Property<string>("INSTANCE")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AGENT_HOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AGENT_VERSION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ALERT_LOG_FILE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APLICATIVO_BBDD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BACKGROUND_DUMP_DEST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CHARACTER_SET")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CORE_DUMP_DEST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DATABASE_CREATION_DATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DBSIZE_TOTAL_MB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DBSIZE_USED_MB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DB_BLOCKSIZE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DB_COMPATIBLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMD_URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENTORNO_BBDD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENTORNO_HOST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HOST_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LISTENER_PORT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LOG_ARCHIVE_DEST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LOG_ARCHIVE_MODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NCHARACTER_SET")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ORACLE_COMPONENTS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ORACLE_HOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("REDOSIZE_MB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SCHEMAS_USERS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SERVER_PACKAGE_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SGA_DETALLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SGA_TOTAL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SITUACION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SO_VERSION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STARTUP_TIME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TARGET_GUID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USER_DUMP_DEST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VERSION")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("INSTANCE");

                    b.ToTable("TblServidoresOracle_GRID12");
                });

            modelBuilder.Entity("Dominio.TblGrupoBD_fs", b =>
                {
                    b.Property<string>("Consulta")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("ConsultaFSID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescripcionConsulta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Entorno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoBD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UltimaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimoUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VersionBD")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Consulta");

                    b.ToTable("TblGrupoBD_fs");
                });

            modelBuilder.Entity("Dominio.TblServidoresSQLServer", b =>
                {
                    b.Property<string>("CompleteName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Collation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataBaseCreationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EditionID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineEdition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ErrorLog")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullTextInstalled")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HadrManagerStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstanceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntegratedSecurityOnly")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsClustered")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ListaBBDD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalSQLServerPort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NetbiosName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductVersion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeDB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SqlCharSetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UmbralMonitorizacionLog")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UmbralMonitorizacionRows")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompleteName");

                    b.ToTable("tblServidoresSQLServer_BBDD");
                });

            modelBuilder.Entity("Dominio.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Dominio.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Dominio.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Dominio.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
