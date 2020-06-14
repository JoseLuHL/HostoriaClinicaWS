using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HostoriaClinicaWS.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace HostoriaClinicaWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ArlController : ControllerBase
    {
        private readonly HistoriaClinicaContext _context;

        public ArlController(HistoriaClinicaContext context)
        {
            _context = context;
        }

        // GET: api/Arl
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Arl>>> GetArl()
        {
            return await _context.Arl.ToListAsync();
        }

        // GET: api/Arl/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Arl>> GetArl(int id)
        {
            var arl = await _context.Arl.FindAsync(id);

            if (arl == null)
            {
                return NotFound();
            }

            return arl;
        }

        // PUT: api/Arl/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArl(int id, Arl arl)
        {
            if (id != arl.ArlCodigo)
            {
                return BadRequest();
            }

            _context.Entry(arl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArlExists(id))
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

        // POST: api/Arl
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Arl>> PostArl(Arl arl)
        {
            _context.Arl.Add(arl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArl", new { id = arl.ArlCodigo }, arl);
        }

        // DELETE: api/Arl/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Arl>> DeleteArl(int id)
        {
            var arl = await _context.Arl.FindAsync(id);
            if (arl == null)
            {
                return NotFound();
            }

            _context.Arl.Remove(arl);
            await _context.SaveChangesAsync();

            return arl;
        }

        private bool ArlExists(int id)
        {
            return _context.Arl.Any(e => e.ArlCodigo == id);
        }
    }
}
