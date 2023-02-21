using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogEngineApp.Context;
using BlogEngineApp.Models;
using System.ComponentModel;
using NuGet.Protocol;
using Microsoft.Extensions.Hosting;
using System.Collections.Specialized;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections;
using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace BlogEngineApp.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly BlogEngineDBContext _context;

        public PostsController(BlogEngineDBContext context)
        {
            _context = context;
        }

        // GET: api/Posts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Posts>>> GetPost()
        {
          if (_context.Posts== null)
          {
              return NotFound();
          }

            var query = (from post in _context.Posts
                        where post.Status == "published"
                        select post).ToListAsync();

            if (_context.Coments == null)
            {
                return NotFound();
            }

            return await query;
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Posts>> GetPosts(int id)
        {
            if (_context.Posts == null)
            {
                return NotFound();
            }

            var posts = await _context.Posts.FindAsync(id);

            if (posts == null)
            {
                return NotFound();
            }

            return posts;

        }

        // PUT: api/Posts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPosts(int id, Posts posts)
        {
            //var myUser = _context.Users.FindAsync(id);
            //var myRole = _context.Roles.FindAsync(id);


            if (id != posts.Id)
            {
                return BadRequest();

            }

            _context.Entry(posts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostsExists(id))
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

        // POST: api/Posts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Posts>> Posts(Posts posts)
        {
          if (_context.Posts == null)
          {
              return Problem("Entity set 'BlogEngineDBContext.Post'  is null.");
          }
            _context.Posts.Add(posts);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPosts", new { id = posts.Id }, posts);
        }

        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePosts(int id)
        {
            if (_context.Posts == null)
            {
                return NotFound();
            }
            var posts = await _context.Posts.FindAsync(id);
            if (posts == null)
            {
                return NotFound();
            }

            _context.Posts.Remove(posts);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostsExists(int id)
        {
            return (_context.Posts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
