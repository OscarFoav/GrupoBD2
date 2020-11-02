using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.Contratos;
using Aplicacion.GrupoBD;
using Dominio;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Persistencia;
using Persistencia.DapperConexion;
using Persistencia.DapperConexion.GrupoBD2;
using Seguridad;
using WebAPI.Middleware;

namespace WebAPI
{
    // Modificación para Git - segunda prueba
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GrupoBD2_Context>(opt => {
                // la cadena de conexión se guarda en appsettings.json de WebAPI / Properties
                opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            // Acceso para Dapper a SQL Server
            services.AddOptions();
            services.Configure<ConexionConfiguracion>(Configuration.GetSection("ConnectionStrings"));

            services.AddMediatR(typeof(ConsultaGrupoBD_fs.Manejador).Assembly);
            services.AddControllers(opt => {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                opt.Filters.Add(new AuthorizeFilter(policy));
            })
            .AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssemblyContaining<NuevoGrupoBD_fs>() );

            // Instanciar clase Usuarios (Core services)
            var builder = services.AddIdentityCore<Usuario>();
            var identityBuilder = new IdentityBuilder(builder.UserType, builder.Services);
            identityBuilder.AddEntityFrameworkStores<GrupoBD2_Context>();
            identityBuilder.AddSignInManager<SignInManager<Usuario>>();
            services.TryAddSingleton<ISystemClock, SystemClock>();

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Mi palabra secreta"));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>{
                opt.TokenValidationParameters = new TokenValidationParameters{
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = key,
                    ValidateAudience = false,
                    ValidateIssuer = false
                };
            });
            
            services.AddScoped<IJwtGenerador, JwtGenerador>();
            services.AddScoped<IUsuarioSesion, UsuarioSesion>();

            // relacionar WebAPI con DapperConexion y, debajo, con GrupoBD2
            services.AddTransient<IFactoryConnection, FactoryConnection>();
            services.AddScoped<IGrupoBD2, GrupoBD2Repositorio>();
        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Incluimos nuestro Middleware como método Middleware
            app.UseMiddleware<ManejadorErrorMiddleware>();
            if (env.IsDevelopment())
            {
                // app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
