using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Agonaika01.Models;

namespace Agonaika01.Controllers
{
    [Produces("application/json")]
    [Route("api/Timesheets")]
    public class TimesheetsController : Controller
    {
        private readonly AgoCRUDTestContext _context;

        public TimesheetsController(AgoCRUDTestContext context)
        {
            _context = context;
        }

        // GET: api/Timesheets
        [HttpGet]
        public IEnumerable<Timesheet> GetTimesheet()
        {
            return _context.Timesheet;
        }

        // GET: api/Timesheets/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTimesheet([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var timesheet = await _context.Timesheet.SingleOrDefaultAsync(m => m.Id == id);

            if (timesheet == null)
            {
                return NotFound();
            }

            return Ok(timesheet);
        }

        // PUT: api/Timesheets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTimesheet([FromRoute] long id, [FromBody] Timesheet timesheet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != timesheet.Id)
            {
                return BadRequest();
            }

            _context.Entry(timesheet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimesheetExists(id))
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

        // POST: api/Timesheets
        [HttpPost]
        public async Task<IActionResult> PostTimesheet([FromBody] Timesheet timesheet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Timesheet.Add(timesheet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TimesheetExists(timesheet.Id))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTimesheet", new { id = timesheet.Id }, timesheet);
        }

        // DELETE: api/Timesheets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTimesheet([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var timesheet = await _context.Timesheet.SingleOrDefaultAsync(m => m.Id == id);
            if (timesheet == null)
            {
                return NotFound();
            }

            _context.Timesheet.Remove(timesheet);
            await _context.SaveChangesAsync();

            return Ok(timesheet);
        }

        private bool TimesheetExists(long id)
        {
            return _context.Timesheet.Any(e => e.Id == id);
        }
    }
}