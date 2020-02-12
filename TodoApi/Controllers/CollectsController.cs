using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectsController : ControllerBase
    {
        private readonly DataContext _context;

        public CollectsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Collects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Collect>>> GetCollects()
        {
            return await _context.Collects.ToListAsync();
        }

        // GET: api/Collects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Collect>> GetCollect(int id)
        {
            var collect = await _context.Collects.FindAsync(id);

            if (collect == null)
            {
                return NotFound();
            }

            return collect;
        }

        // PUT: api/Collects/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCollect(int id, Collect collect)
        {
            if (id != collect.Id)
            {
                return BadRequest();
            }

            _context.Entry(collect).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CollectExists(id))
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

        // POST: api/Collects
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Collect>> PostCollect(Collect collect)
        {
            _context.Collects.Add(collect);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCollect", new { id = collect.Id }, collect);
        }

        // DELETE: api/Collects/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Collect>> DeleteCollect(int id)
        {
            var collect = await _context.Collects.FindAsync(id);
            if (collect == null)
            {
                return NotFound();
            }

            _context.Collects.Remove(collect);
            await _context.SaveChangesAsync();

            return collect;
        }

        private bool CollectExists(int id)
        {
            return _context.Collects.Any(e => e.Id == id);
        }
    }
}
