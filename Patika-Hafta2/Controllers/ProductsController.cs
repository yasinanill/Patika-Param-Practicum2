using Microsoft.AspNetCore.Mvc;
using Patika_Hafta1_Odev.Data;
using Patika_Hafta1_Odev.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patika_Hafta1_Odev.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {


        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<List<Product>> GetAll()
        {
            return await _productRepository.GetAllAsync();

        }

        [HttpGet("GetById")]
        public async Task<Product> GetById([FromQuery]int id)
        {
            return await _productRepository.GetByIdAsync(id);

        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            var addedProduct = await _productRepository.CreateAsync(product);
            return Created("", addedProduct);

        }
        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
            var checkProduct = await _productRepository.GetByIdAsync(product.Id);
            if (checkProduct == null)
            {
                return NotFound(product.Id);
            }
            await _productRepository.UpdateAsync(product);
            return NoContent();
            
        }
        [HttpDelete]
        public async Task<IActionResult> Remove(int id)
        {
            var checkProduct = await _productRepository.GetByIdAsync(id);
            if (checkProduct == null)
            {
                return NotFound(id);
            }
            await _productRepository.RemoveAsync(id);
            return NoContent();

        }



    }
}
