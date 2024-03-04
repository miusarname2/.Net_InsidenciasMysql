using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InsidenciasMysql.DataAccess;
using InsidenciasMysql.Model.DataModels;

namespace InsidenciasMysql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeOfInsidencesController : ControllerBase
    {
        private readonly InsidencesDbContext _context;

        public TypeOfInsidencesController(InsidencesDbContext context)
        {
            _context = context;
        }

        // GET: api/TypeOfInsidences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeOfInsidence>>> GetInsidencesTypes()
        {
            return await _context.InsidencesTypes.ToListAsync();
        }

        // GET: api/TypeOfInsidences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeOfInsidence>> GetTypeOfInsidence(int id)
        {
            var typeOfInsidence = await _context.InsidencesTypes.FindAsync(id);

            if (typeOfInsidence == null)
            {
                return NotFound();
            }

            return typeOfInsidence;
        }

        // PUT: api/TypeOfInsidences/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeOfInsidence(int id, TypeOfInsidence typeOfInsidence)
        {
            if (id != typeOfInsidence.Id)
            {
                return BadRequest();
            }

            _context.Entry(typeOfInsidence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeOfInsidenceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TypeOfInsidences
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TypeOfInsidence>> PostTypeOfInsidence(TypeOfInsidence typeOfInsidence)
        {
            _context.InsidencesTypes.Add(typeOfInsidence);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeOfInsidence", new { id = typeOfInsidence.Id }, typeOfInsidence);
        }

        // DELETE: api/TypeOfInsidences/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeOfInsidence(int id)
        {
            var typeOfInsidence = await _context.InsidencesTypes.FindAsync(id);
            if (typeOfInsidence == null)
            {
                return NotFound();
            }

            _context.InsidencesTypes.Remove(typeOfInsidence);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TypeOfInsidenceExists(int id)
        {
            return _context.InsidencesTypes.Any(e => e.Id == id);
        }
    }
}
