using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShadowAPI.Models;

namespace shadowsheet_api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class RunnerController : Controller
    {
        private readonly RunnerContext _context;

        public RunnerController(RunnerContext context)
        {
            _context = context;
        }

        // GET: api/Runner
        [HttpGet]
        public IEnumerable<Runner> GetRunner()
        {
            return _context.Runner;

            
        }

        // GET: api/Runner/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRunner([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var runner = await _context.Runner.SingleOrDefaultAsync(m => m.ID == id);

            if (runner == null)
            {
                return NotFound();
            }

            return Ok(runner);
        }

        // PUT: api/Runner/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRunner([FromRoute] long id, [FromBody] Runner runner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != runner.ID)
            {
                return BadRequest();
            }

            _context.Entry(runner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RunnerExists(id))
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

        // POST: api/Runner
        [HttpPost]
        public async Task<IActionResult> PostRunner([FromBody] Runner runner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Runner.Add(runner);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRunner", new { id = runner.ID }, runner);
        }

        // DELETE: api/Runner/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRunner([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var runner = await _context.Runner.SingleOrDefaultAsync(m => m.ID == id);
            if (runner == null)
            {
                return NotFound();
            }

            _context.Runner.Remove(runner);
            await _context.SaveChangesAsync();

            return Ok(runner);
        }

        private bool RunnerExists(long id)
        {
            return _context.Runner.Any(e => e.ID == id);
        }
    }
}