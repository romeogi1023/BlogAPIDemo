using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPIDemo.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPIDemo.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriService _categoriService;
        public CategoriesController(ICategoriService categoriService)
        {
            _categoriService = categoriService;
        }

        // GET: api/Categories
        [HttpGet]
        public IActionResult GetCategory()
        {
            var data = _categoriService.GetList();
            return Ok(data);
        }


    }
}