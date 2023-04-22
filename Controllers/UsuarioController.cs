using Microsoft.AspNetCore.Mvc;

namespace usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {

        private static List<API_C_.Models.Usuario> Usuarios()
        {

            return new List<API_C_.Models.Usuario> {
                new API_C_.Models.Usuario{Nome="Carlos", id=1, }
                };
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(Usuarios());
        }


        [HttpPost]
        public IActionResult Post(API_C_.Models.Usuario usuario)
        {
            var usuarios = Usuarios();
            usuarios.Add(usuario);
            return Ok(usuarios);
        }


    }
}