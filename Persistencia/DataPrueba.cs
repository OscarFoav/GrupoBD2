using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Identity;

namespace Persistencia
{
    public class DataPrueba
    {
        // inserta datos en la BD
        public static async Task InsertarData(GrupoBD2_Context context, UserManager<Usuario> usuarioManager ){
            if(!usuarioManager.Users.Any()){
                var usuario = new Usuario{NombreCompleto = "Óscar", UserName = "OFA", Email = "oscar.foav@gmail.com"};
                await usuarioManager.CreateAsync(usuario, "Password123$");
            }
        }
    }
}