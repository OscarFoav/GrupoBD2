using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class IdentityCoreInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    NombreCompleto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblGrupoBD_fs",
                columns: table => new
                {
                    Consulta = table.Column<string>(nullable: false),
                    ConsultaFSID = table.Column<Guid>(nullable: false),
                    DescripcionConsulta = table.Column<string>(nullable: true),
                    TipoBD = table.Column<string>(nullable: true),
                    VersionBD = table.Column<string>(nullable: true),
                    Entorno = table.Column<string>(nullable: true),
                    UltimaModificacion = table.Column<DateTime>(nullable: true),
                    UltimoUsuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblGrupoBD_fs", x => x.Consulta);
                });

            migrationBuilder.CreateTable(
                name: "TblServidoresOracle_GRID12",
                columns: table => new
                {
                    INSTANCE = table.Column<string>(nullable: false),
                    HOST_NAME = table.Column<string>(nullable: true),
                    SITUACION = table.Column<string>(nullable: true),
                    ENTORNO_BBDD = table.Column<string>(nullable: true),
                    APLICATIVO_BBDD = table.Column<string>(nullable: true),
                    ENTORNO_HOST = table.Column<string>(nullable: true),
                    SO_VERSION = table.Column<string>(nullable: true),
                    AGENT_HOME = table.Column<string>(nullable: true),
                    EMD_URL = table.Column<string>(nullable: true),
                    AGENT_VERSION = table.Column<string>(nullable: true),
                    VERSION = table.Column<string>(nullable: true),
                    ORACLE_HOME = table.Column<string>(nullable: true),
                    LISTENER_PORT = table.Column<string>(nullable: true),
                    DB_BLOCKSIZE = table.Column<string>(nullable: true),
                    CHARACTER_SET = table.Column<string>(nullable: true),
                    NCHARACTER_SET = table.Column<string>(nullable: true),
                    STARTUP_TIME = table.Column<string>(nullable: true),
                    DATABASE_CREATION_DATE = table.Column<string>(nullable: true),
                    ALERT_LOG_FILE = table.Column<string>(nullable: true),
                    BACKGROUND_DUMP_DEST = table.Column<string>(nullable: true),
                    CORE_DUMP_DEST = table.Column<string>(nullable: true),
                    USER_DUMP_DEST = table.Column<string>(nullable: true),
                    LOG_ARCHIVE_MODE = table.Column<string>(nullable: true),
                    LOG_ARCHIVE_DEST = table.Column<string>(nullable: true),
                    SERVER_PACKAGE_NAME = table.Column<string>(nullable: true),
                    SGA_TOTAL = table.Column<string>(nullable: true),
                    SGA_DETALLE = table.Column<string>(nullable: true),
                    DBSIZE_TOTAL_MB = table.Column<string>(nullable: true),
                    DBSIZE_USED_MB = table.Column<string>(nullable: true),
                    REDOSIZE_MB = table.Column<string>(nullable: true),
                    DB_COMPATIBLE = table.Column<string>(nullable: true),
                    ORACLE_COMPONENTS = table.Column<string>(nullable: true),
                    TARGET_GUID = table.Column<string>(nullable: true),
                    SCHEMAS_USERS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblServidoresOracle_GRID12", x => x.INSTANCE);
                });

            migrationBuilder.CreateTable(
                name: "tblServidoresSQLServer_BBDD",
                columns: table => new
                {
                    CompleteName = table.Column<string>(nullable: false),
                    MachineName = table.Column<string>(nullable: true),
                    NetbiosName = table.Column<string>(nullable: true),
                    InstanceName = table.Column<string>(nullable: true),
                    LocalSQLServerPort = table.Column<string>(nullable: true),
                    Edition = table.Column<string>(nullable: true),
                    EditionID = table.Column<string>(nullable: true),
                    EngineEdition = table.Column<string>(nullable: true),
                    Collation = table.Column<string>(nullable: true),
                    FullTextInstalled = table.Column<string>(nullable: true),
                    HadrManagerStatus = table.Column<string>(nullable: true),
                    IntegratedSecurityOnly = table.Column<string>(nullable: true),
                    ProductVersion = table.Column<string>(nullable: true),
                    ProductLevel = table.Column<string>(nullable: true),
                    IsClustered = table.Column<string>(nullable: true),
                    SqlCharSetName = table.Column<string>(nullable: true),
                    DataBaseCreationDate = table.Column<string>(nullable: true),
                    SizeDB = table.Column<string>(nullable: true),
                    ErrorLog = table.Column<string>(nullable: true),
                    UmbralMonitorizacionRows = table.Column<string>(nullable: true),
                    UmbralMonitorizacionLog = table.Column<string>(nullable: true),
                    ListaBBDD = table.Column<string>(nullable: true),
                    Comentario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblServidoresSQLServer_BBDD", x => x.CompleteName);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "TblGrupoBD_fs");

            migrationBuilder.DropTable(
                name: "TblServidoresOracle_GRID12");

            migrationBuilder.DropTable(
                name: "tblServidoresSQLServer_BBDD");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
