using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Genshin.Models;

namespace Genshin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementsController : ControllerBase
    {
        private readonly GenshinDbContext _context;

        public ElementsController(GenshinDbContext context)
        {
            _context = context;
        }

        // GET: api/Elements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Elements>>> GetElements()
        {
            return await _context.Elements.ToListAsync();
        }

        // GET: api/Elements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Elements>> GetElements(int id)
        {
            var elements = await _context.Elements.FindAsync(id);

            if (elements == null)
            {
                return NotFound();
            }

            return elements;
        }

        // PUT: api/Elements/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElements(int id, Elements elements)
        {
            if (id != elements.Id)
            {
                return BadRequest();
            }

            _context.Entry(elements).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElementsExists(id))
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

        // POST: api/Elements
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Elements>> PostElements(Elements elements)
        {
            _context.Elements.Add(elements);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetElements", new { id = elements.Id }, elements);
        }

        // DELETE: api/Elements/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Elements>> DeleteElements(int id)
        {
            var elements = await _context.Elements.FindAsync(id);
            if (elements == null)
            {
                return NotFound();
            }

            _context.Elements.Remove(elements);
            await _context.SaveChangesAsync();

            return elements;
        }

        private bool ElementsExists(int id)
        {
            return _context.Elements.Any(e => e.Id == id);
        }
    }
}
