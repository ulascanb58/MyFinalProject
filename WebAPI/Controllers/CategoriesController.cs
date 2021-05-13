using BusinessLayer.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("GetAll")] //bana data ver
        public IActionResult GetAll()
        {

            var result = _categoryService.GetAll();

            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {

            var result = _categoryService.GetById(id);

            if (result.Success == true)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);



        }

        /*
        [HttpPost("Add")] // ben sana data vericem
        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }*/
    }
}