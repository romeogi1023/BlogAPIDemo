using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPIDemo.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlogAPIDemo.Services;
using BlogAPIDemo.Services.Interfaces;
using BlogAPIDemo.Domain.Dtos;
using Microsoft.EntityFrameworkCore;

namespace BlogAPIDemo.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService _commentsService;

        public CommentsController(ICommentService commentService)
        {
            _commentsService = commentService;
        }
        //Get: api/Comments
        [HttpGet]
        public IActionResult GetComments() 
        {
            var data = _commentsService.GetList();
            return Ok(data);
        }
        //Get: api/Comments/5
        [HttpGet("{id}")]
        public IActionResult GetComments(int id) 
        {
            var comments = _commentsService.FindById(id);
            if (comments == null) 
            {
                return NotFound();
            }
            return Ok(comments);
        }
        // POST: api/Comments
        [HttpPost]
        public IActionResult PostComments([FromForm] CommentsDto comments) 
        {
            try
            {
                var result = _commentsService.Create(comments);
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
        public IActionResult DeleteComments(int id) 
        {
            var comments = _commentsService.FindById(id);
            if (comments == null) 
            {
                return NotFound();
            }
            return Ok(comments);
        }
    }
}