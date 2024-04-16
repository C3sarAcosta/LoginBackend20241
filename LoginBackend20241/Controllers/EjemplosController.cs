using LoginBackend20241.Context;
using LoginBackend20241.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoginBackend20241.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EjemplosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public EjemplosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Ejemplo>>> Get()
        {
            var ejemplos = await context.Ejemplos.ToListAsync();
            return Ok(ejemplos);
        }


    }
}
