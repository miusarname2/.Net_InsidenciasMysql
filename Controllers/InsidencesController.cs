using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InsidenciasMysql.DataAccess;
using InsidenciasMysql.Model.DataModels;
using System.Text.Json.Serialization;
using System.Text.Json;
using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json;

namespace InsidenciasMysql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsidencesController : ControllerBase
    {
        private readonly InsidencesDbContext _context;
        private readonly JsonSerializerOptions _jsonOptions;

        public InsidencesController(InsidencesDbContext context)
        {
            _context = context;
            _jsonOptions = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };
        }

        // GET: camper/Insidences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Insidences>>> GetInsidences()
        {
            return await _context.Insidences.ToListAsync();
        }

        // GET: camper/Insidences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Insidences>> GetInsidences(int id)
        {
            var insidences = await _context.Insidences.FindAsync(id);

            if (insidences == null)
            {
                return NotFound();
            }

            return insidences;
        }

        // PUT: camper/Insidences/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInsidences(int id, Insidences insidences)
        {
            if (id != insidences.Id)
            {
                return BadRequest();
            }

            _context.Entry(insidences).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InsidencesExists(id))
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

        // POST: camper/Insidences
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Insidences>> PostInsidences(Insidences insidences)
        {
            try
            {
                string personaJson = JsonConvert.SerializeObject(insidences);
                insidences.reporterName = "<Camper>" + insidences.reporterName;
                _context.Insidences.Add(insidences);
                await _context.SaveChangesAsync();


                return Ok(personaJson);
            }
            catch (Exception ex)
            {
                return CreatedAtAction("GetInsidences", new { id = insidences.Id }, insidences);
            }
        }

        private bool InsidencesExists(int id)
        {
            return _context.Insidences.Any(e => e.Id == id);
        }
    }
}
