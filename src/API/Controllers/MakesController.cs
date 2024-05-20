using API.Models;
using API.Presistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MakesController : ControllerBase
    {
        private readonly DataContext _ctx;
        public MakesController(DataContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public async Task<IActionResult> GetMakesAsync()
        {
            IEnumerable<Make> result = await _ctx.Makes.Include(a => a.Models).ToListAsync();
            return Ok(result);
        }


    }
}