using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPIDemo.Domain.Dtos;
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
        // GET: api/Categories/id
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var category = _categoriService.FindById(id);
            if(category ==null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        // Post: api/Categories
        [HttpPost]
        public IActionResult PostCategory([FromBody] CategoryDto categoryDto) 
        {
            var result = _categoriService.Create(categoryDto);
            if (result) {
                return RedirectToAction("GetCategory");
            }
            return Ok(new { Message = "Create Error" });
        }
        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id) 
        {
            var category = CategoryExists(id);
            if (category) {
                _categoriService.Delete(id);
                return Ok("delete ok");
            }
            return NotFound();
        }

        private bool CategoryExists(int id)
        {
            var category = _categoriService.FindById(id);
            if (category == null) 
            {
                return false;
            }
            return true;
        }
    }
}