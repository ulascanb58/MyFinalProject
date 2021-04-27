using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //Attribute
    public class ProductsController : ControllerBase
    {
        //IoC Container -- Inversion of Control
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("GetAll")] //bana data ver
        public IActionResult GetAll()
        {
            
              var result = _productService.GetAll();

              if (result.Success == true)
              {
                  return Ok(result);
              }

              return BadRequest(result);

        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {

            var result = _productService.GetById(id);

            if (result.Success == true)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);

        }

        [HttpPost("Add")] // ben sana data vericem
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success == true)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}