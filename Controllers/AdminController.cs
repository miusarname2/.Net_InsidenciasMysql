using Microsoft.AspNetCore.Mvc;
using InsidenciasMysql.DataAccess;
using InsidenciasMysql.Model.DataModels;
using Microsoft.EntityFrameworkCore;


namespace InsidenciasMysql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly InsidencesDbContext _context;

        public AdminController(InsidencesDbContext context)
        {
            _context = context;
        }

        // GET: api/Admin
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Insidences>>> GetInsidences()
        {
            return await _context.Insidences.ToListAsync();
        }

        // GET: camper/Insidences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Insidences>> GetInsidence(int id)
        {
            var insidences = await _context.Insidences.FindAsync(id);

            if (insidences == null)
            {
                return NotFound();
            }

            return insidences;
        }
    }
}
