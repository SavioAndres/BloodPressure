using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BPressureController : Controller
    {
        private readonly BPressureContext _context;

        public BPressureController(BPressureContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BPressure>> Get()
        {
            return _context.BPressures.ToList();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BPressure>> GetTodoItem(int id)
        {
            var todoItem = await _context.BPressures.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        // POST: api/TodoItems
        [HttpPost]
        public async Task<ActionResult<BPressure>> PostTodoItem(BPressure todoItem)
        {
            _context.BPressures.Add(todoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.BPressureId }, todoItem);
        }

        // PUT: api/TodoItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(int id, BPressure todoItem)
        {
            if (id != todoItem.BPressureId)
            {
                return BadRequest();
            }

            _context.Entry(todoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
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

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BPressure>> DeleteTodoItem(int id)
        {
            var todoItem = await _context.BPressures.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.BPressures.Remove(todoItem);
            await _context.SaveChangesAsync();

            return todoItem;
        }

        private bool TodoItemExists(int id) => 
            _context.BPressures.Any(e => e.BPressureId == id);

        ~BPressureController()
        {
            _context.Dispose();
        }

    }
}
