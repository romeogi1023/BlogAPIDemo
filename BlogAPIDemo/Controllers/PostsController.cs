using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPIDemo.Domain.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly BlogContext _context;

        public PostsController(BlogContext context) 
        {
            _context = context;
        }
    }
}