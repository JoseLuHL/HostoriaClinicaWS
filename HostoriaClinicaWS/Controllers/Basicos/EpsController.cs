using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HostoriaClinicaWS.Models;

namespace HostoriaClinicaWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpsController : ControllerBase
    {
        private readonly HistoriaClinicaContext _context;

        public EpsController(HistoriaClinicaContext context)
        {
            _context = context;
        }

        // GET: api/Eps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eps>>> GetEps()
        {
            return await _context.Eps.ToListAsync();
        }

        // GET: api/Eps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eps>> GetEps(int id)
        {
            var eps = await _context.Eps.FindAsync(id);

            if (eps == null)
            {
                return NotFound();
            }

            return eps;
        }

        // PUT: api/Eps/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEps(int id, Eps eps)
        {
            if (id != eps.EpsCodigo)
            {
                return BadRequest();
            }

            _context.Entry(eps).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EpsExists(id))
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

        // POST: api/Eps
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eps>> PostEps(Eps eps)
        {
            _context.Eps.Add(eps);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEps", new { id = eps.EpsCodigo }, eps);
        }

        // DELETE: api/Eps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eps>> DeleteEps(int id)
        {
            var eps = await _context.Eps.FindAsync(id);
            if (eps == null)
            {
                return NotFound();
            }

            _context.Eps.Remove(eps);
            await _context.SaveChangesAsync();

            return eps;
        }

        private bool EpsExists(int id)
        {
            return _context.Eps.Any(e => e.EpsCodigo == id);
        }
    }
}
