using IntroduccionAEFCore.DTOs;
using IntroduccionAEFCore.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace IntroduccionAEFCore.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GenerosControllers: ControllerBase
    {
        private readonly ApplicactionDBContext context;

        public GenerosControllers(ApplicactionDBContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult>Post(GeneroCreacionDTO generoCreacion)
        {
            var genero = new Genero
            {
                Nombre = generoCreacion.Nombre,
            };
            context.Add(genero);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
