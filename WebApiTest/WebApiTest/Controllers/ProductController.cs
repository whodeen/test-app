using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Services.Abastraction;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private IMongoCollection<Product> _productCollection;

        public ProductController(IMongoClient client, IProductService productService)
        {
            var dataBase = client.GetDatabase("test");
            _productService = productService;
            _productCollection = dataBase.GetCollection<Product>("products"); ;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _productCollection.Find(product => product.InStock).Limit(50).ToList();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(product);
                _productCollection.InsertOne(product);
                return Ok(product);
            }
            return BadRequest(ModelState);
        }
    }
}
