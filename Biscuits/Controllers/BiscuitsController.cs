using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Biscuiterie.Models;
using Buiscuiterie.Data;
using Microsoft.AspNetCore.Authorization;

namespace Buiscuiterie.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BiscuitsController : ControllerBase
    {
        private readonly BuiscuiterieContext _context;

        public BiscuitsController(BuiscuiterieContext context)
        {
            _context = context;
        }

        // GET: api/Biscuits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Biscuit>>> GetBiscuit()
        {
          if (_context.Biscuit == null)
          {
              return NotFound();
          }
            return await _context.Biscuit.ToListAsync();
        }

        // GET: api/Biscuits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Biscuit>> GetBiscuit(int id)
        {
          if (_context.Biscuit == null)
          {
              return NotFound();
          }
            var biscuit = await _context.Biscuit.FindAsync(id);

            if (biscuit == null)
            {
                return NotFound();
            }

            return biscuit;
        }

        // PUT: api/Biscuits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBiscuit(int id, Biscuit biscuit)
        {
            if (id != biscuit.BiscuitId)
            {
                return BadRequest();
            }

            _context.Entry(biscuit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BiscuitExists(id))
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

        // POST: api/Biscuits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Biscuit>> PostBiscuit(Biscuit biscuit)
        {
          if (_context.Biscuit == null)
          {
              return Problem("Entity set 'BuiscuiterieContext.Biscuit'  is null.");
          }
            _context.Biscuit.Add(biscuit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBiscuit", new { id = biscuit.BiscuitId }, biscuit);
        }

        // DELETE: api/Biscuits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBiscuit(int id)
        {
            if (_context.Biscuit == null)
            {
                return NotFound();
            }
            var biscuit = await _context.Biscuit.FindAsync(id);
            if (biscuit == null)
            {
                return NotFound();
            }

            _context.Biscuit.Remove(biscuit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BiscuitExists(int id)
        {
            return (_context.Biscuit?.Any(e => e.BiscuitId == id)).GetValueOrDefault();
        }
    }
}
