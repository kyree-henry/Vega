using API.Contracts;
using API.Models;
using API.Presistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MakesController : ControllerBase
    {
        private readonly DataContext _ctx;
        private readonly IMapper _mapper;
        public MakesController(DataContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMakesAsync()
        {
            IEnumerable<Make>? makes = await _ctx.Makes.Include(a => a.Models).ToListAsync();
            IEnumerable<MakeResource>? result = _mapper.Map<IEnumerable<MakeResource>>(makes);
            return Ok(result);
        }

    }
}