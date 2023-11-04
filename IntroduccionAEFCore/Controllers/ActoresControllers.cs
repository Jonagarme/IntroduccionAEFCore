using AutoMapper;
using IntroduccionAEFCore.DTOs;
using IntroduccionAEFCore.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace IntroduccionAEFCore.Controllers
{
    [ApiController]
    [Route("api/actores")]
    public class ActoresControllers: ControllerBase
    {
        private readonly ApplicactionDBContext context;
        private readonly IMapper mapper;

        public ActoresControllers(ApplicactionDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(ActorCreacionDTO actorCreacionDTO)
        {
            var actor = mapper.Map<Actor>(actorCreacionDTO);
            context.Add(actor);
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
