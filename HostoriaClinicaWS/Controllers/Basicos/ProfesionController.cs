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
    public class ProfesionController : ControllerBase
    {
        private readonly HistoriaClinicaContext _context;

        public ProfesionController(HistoriaClinicaContext context)
        {
            _context = context;
        }

        // GET: api/Profesion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profesion>>> GetProfesion()
        {
            return await _context.Profesion.ToListAsync();
        }

        // GET: api/Profesion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Profesion>> GetProfesion(string id)
        {
            var profesion = await _context.Profesion.FindAsync(id);

            if (profesion == null)
            {
                return NotFound();
            }

            return profesion;
        }

        // PUT: api/Profesion/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfesion(string id, Profesion profesion)
        {
            if (id != profesion.ProfCodigo)
            {
                return BadRequest();
            }

            _context.Entry(profesion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfesionExists(id))
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

        // POST: api/Profesion
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Profesion>> PostProfesion(Profesion profesion)
        {
            _context.Profesion.Add(profesion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProfesionExists(profesion.ProfCodigo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProfesion", new { id = profesion.ProfCodigo }, profesion);
        }

        // DELETE: api/Profesion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Profesion>> DeleteProfesion(string id)
        {
            var profesion = await _context.Profesion.FindAsync(id);
            if (profesion == null)
            {
                return NotFound();
            }

            _context.Profesion.Remove(profesion);
            await _context.SaveChangesAsync();

            return profesion;
        }

        private bool ProfesionExists(string id)
        {
            return _context.Profesion.Any(e => e.ProfCodigo == id);
        }
    }
}
