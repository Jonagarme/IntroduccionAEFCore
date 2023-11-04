using AutoMapper;
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
        private readonly IMapper mapper;

        public GenerosControllers(ApplicactionDBContext context,
            IMapper mapper )
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult>Post(GeneroCreacionDTO generoCreacion)
        {
            var genero = mapper.Map<Genero>(generoCreacion);
            context.Add(genero);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("varios")]
        public async Task<ActionResult> Post(GeneroCreacionDTO[] generosCreacionDTO)
        {
            var generos = mapper.Map<Genero[]>(generosCreacionDTO);
            context.AddRange(generos);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
