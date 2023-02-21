using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogEngineApp.Context;
using BlogEngineApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Xml.Linq;
using Microsoft.Extensions.Hosting;
using BlogEngineApp.ViewsDTO;

namespace BlogEngineApp.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class ComentsController : ControllerBase
    {
        private readonly BlogEngineDBContext _context;

        public ComentsController(BlogEngineDBContext context)
        {
            _context = context;
        }

        // GET: api/Coments
        [HttpGet]
        public  List<ViewComents> GetComents()
        {
            try
            {
                var query1 = (from _post in _context.Posts
                              join _coment in _context.Coments
                              on _post.Id equals _coment.PostId
                              where _post.Status == "published"
                              select new ViewComents
                              {
                                  Id = _post.Id,
                                  Coment = _coment.Coment,
                                  Author = _post.Author
                              }).ToList();
                return query1;
            } 
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
           
        }

        /*// GET: api/Coments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Coments>> GetComents(int id)
        {
          if (_context.Coments == null)
          {
              return NotFound();
          }
            var coments = await _context.Coments.FindAsync(id);

            if (coments == null)
            {
                return NotFound();
            }

            return coments;
        }*/

        /*// PUT: api/Coments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComents(int id, Coments coments)
        {
            if (id != coments.Id)
            {
                return BadRequest();
            }

            _context.Entry(coments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComentsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }*/

        // POST: api/Coments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Coments>> PostComents(Coments coments)
        {
          if (_context.Coments == null)
          {
              return Problem("Entity set 'BlogEngineDBContext.Coments'  is null.");
          }

            _context.Coments.Add(coments);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComents", new { id = coments.Id }, coments);
        }

        // DELETE: api/Coments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComents(int id)
        {
            if (_context.Coments == null)
            {
                return NotFound();
            }
            var coments = await _context.Coments.FindAsync(id);
            if (coments == null)
            {
                return NotFound();
            }

            _context.Coments.Remove(coments);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComentsExists(int id)
        {
            return (_context.Coments?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
