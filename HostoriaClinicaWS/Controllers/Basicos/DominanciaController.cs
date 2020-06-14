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
    public class DominanciaController : ControllerBase
    {
        private readonly HistoriaClinicaContext _context;

        public DominanciaController(HistoriaClinicaContext context)
        {
            _context = context;
        }

        // GET: api/Dominancia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dominancia>>> GetDominancia()
        {
            return await _context.Dominancia.ToListAsync();
        }

        // GET: api/Dominancia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dominancia>> GetDominancia(int id)
        {
            var dominancia = await _context.Dominancia.FindAsync(id);

            if (dominancia == null)
            {
                return NotFound();
            }

            return dominancia;
        }

        // PUT: api/Dominancia/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDominancia(int id, Dominancia dominancia)
        {
            if (id != dominancia.DomCodigo)
            {
                return BadRequest();
            }

            _context.Entry(dominancia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DominanciaExists(id))
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

        // POST: api/Dominancia
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Dominancia>> PostDominancia(Dominancia dominancia)
        {
            _context.Dominancia.Add(dominancia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDominancia", new { id = dominancia.DomCodigo }, dominancia);
        }

        // DELETE: api/Dominancia/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Dominancia>> DeleteDominancia(int id)
        {
            var dominancia = await _context.Dominancia.FindAsync(id);
            if (dominancia == null)
            {
                return NotFound();
            }

            _context.Dominancia.Remove(dominancia);
            await _context.SaveChangesAsync();

            return dominancia;
        }

        private bool DominanciaExists(int id)
        {
            return _context.Dominancia.Any(e => e.DomCodigo == id);
        }
    }
}
