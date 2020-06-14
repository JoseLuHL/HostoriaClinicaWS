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
    public class NivelEducativoesController : ControllerBase
    {
        private readonly HistoriaClinicaContext _context;

        public NivelEducativoesController(HistoriaClinicaContext context)
        {
            _context = context;
        }

        // GET: api/NivelEducativoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NivelEducativo>>> GetNivelEducativo()
        {
            return await _context.NivelEducativo.ToListAsync();
        }

        // GET: api/NivelEducativoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NivelEducativo>> GetNivelEducativo(int id)
        {
            var nivelEducativo = await _context.NivelEducativo.FindAsync(id);

            if (nivelEducativo == null)
            {
                return NotFound();
            }

            return nivelEducativo;
        }

        // PUT: api/NivelEducativoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNivelEducativo(int id, NivelEducativo nivelEducativo)
        {
            if (id != nivelEducativo.NivEduCodigo)
            {
                return BadRequest();
            }

            _context.Entry(nivelEducativo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NivelEducativoExists(id))
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

        // POST: api/NivelEducativoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NivelEducativo>> PostNivelEducativo(NivelEducativo nivelEducativo)
        {
            _context.NivelEducativo.Add(nivelEducativo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNivelEducativo", new { id = nivelEducativo.NivEduCodigo }, nivelEducativo);
        }

        // DELETE: api/NivelEducativoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NivelEducativo>> DeleteNivelEducativo(int id)
        {
            var nivelEducativo = await _context.NivelEducativo.FindAsync(id);
            if (nivelEducativo == null)
            {
                return NotFound();
            }

            _context.NivelEducativo.Remove(nivelEducativo);
            await _context.SaveChangesAsync();

            return nivelEducativo;
        }

        private bool NivelEducativoExists(int id)
        {
            return _context.NivelEducativo.Any(e => e.NivEduCodigo == id);
        }
    }
}
