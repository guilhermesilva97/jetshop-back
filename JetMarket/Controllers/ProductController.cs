using JetMarket.App.Interface;
using JetMarket.Domain.Interface.Repository;
using JetMarket.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JetMarket.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductApplication _productApplication;
        public ProductController(IProductApplication productApplication)
                => _productApplication = productApplication;

        [HttpGet]
        [Route("/get-all-products")]
        public async Task <ActionResult <IEnumerable<Product>>> GetAll()
        {
            var products = await _productApplication.GetAllAsync();

           return Ok(products);
        }

        [HttpGet]
        [Route("/get-product")]
        public async Task<ActionResult<Product>> Get(Guid id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var product = await _productApplication.Get(id);

            return Ok(product);
        }

        [HttpDelete]
        [Route("/delete")]
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var response = await _productApplication.Delete(id);

            return Ok(response);
        }

        [HttpPost]
        [Route("/insert-product")]
        public async Task<ActionResult<Product>> Insert(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var productInsert = await _productApplication.Insert(product);

            return Ok(productInsert);
        }

        [HttpPost]
        [Route("/update-product")]
        public async Task<ActionResult<Product>> Update(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var productUpdate = await _productApplication.Update(product);

            return Ok(productUpdate);
        }
    }
}
