using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPIDemo.Domain.Context;
using BlogAPIDemo.Domain.Dtos;
using BlogAPIDemo.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogAPIDemo.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly BlogContext _context;
        private readonly IPostService _postService;
        public PostsController(BlogContext context,IPostService postService) 
        {
            _context = context;
            _postService = postService;
        }

        //Get api/Posts
        [HttpGet]
        public IActionResult GetPost() 
        {
            var data = _postService.GetList();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult GetPost(int id)
        {
            var post = _postService.FindById(id);
            if (post == null) 
            {
                return NotFound();
            }
            return Ok(post);
        }

        // POST: api/Comments
        [HttpPost]
        public IActionResult PostPost([FromForm] PostDto post)
        {
            try
            {
                var result = _postService.Create(post);
                if (result)
                {
                    return RedirectToAction("GetPost");
                }
                return Ok(new { Message = "Error" });
            }
            catch (DbUpdateConcurrencyException)
            {
                return Ok(new { Message = "Error" });
            }
        }
        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public IActionResult DeletePost(int id)
        {
            var post = _postService.FindById(id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }
    }
}