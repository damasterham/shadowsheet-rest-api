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
    [Route("api/runner/{id}/info")]
    public class InfoController : Controller
    {
        private readonly RunnerContext _context;

        public InfoController(RunnerContext context)
        {
            _context = context;
        }

        // GET: api/Info
        //[HttpGet]
        //public IEnumerable<Info> GetInfo()
        //{
        //    return _context.Info;
        //}

        // GET: api/Info/5
        [HttpGet]
        public async Task<IActionResult> GetInfo([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var info = await _context.Info.SingleOrDefaultAsync(m => m.ID == id);

            if (info == null)
            {
                return NotFound();
            }

            return Ok(info);
        }

        // PUT: api/Info/5
        [HttpPut]
        public async Task<IActionResult> PutInfo([FromRoute] long id, [FromBody] Info info)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != info.ID)
            {
                return BadRequest();
            }

            _context.Entry(info).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InfoExists(id))
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

        // POST: api/Info
        [HttpPost]
        public async Task<IActionResult> PostInfo([FromBody] Info info)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Info.Add(info);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InfoExists(info.ID))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInfo", new { id = info.ID }, info);
        }

        // DELETE: api/Info/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteInfo([FromRoute] long id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var info = await _context.Info.SingleOrDefaultAsync(m => m.ID == id);
        //    if (info == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Info.Remove(info);
        //    await _context.SaveChangesAsync();

        //    return Ok(info);
        //}

        private bool InfoExists(long id)
        {
            return _context.Info.Any(e => e.ID == id);
        }
    }
}