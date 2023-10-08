using AdminOrders.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminOrders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly ProductDetailsDbContext _productDetailsDbContext;


        public ProductDetailsController(ProductDetailsDbContext productDetailsDbContext) 
        {
                _productDetailsDbContext = productDetailsDbContext;
        }

        [HttpGet]
        [Route("GetProductDetails")]
        public async Task<IEnumerable<ProductDetails>> GetProductDetails()
        {
            return await _productDetailsDbContext.ProductDetails.ToListAsync(); 
        }

        [HttpPost]
        [Route("AddProductDetails")]
        public async Task<ProductDetails> AddProductDetails(ProductDetails objProductDetails)
        {
            _productDetailsDbContext.ProductDetails.Add(objProductDetails);
            await _productDetailsDbContext.SaveChangesAsync();
            return objProductDetails;

        }

        [HttpPatch]
        [Route("UpdateProductDetails/{id}")]
        public async Task<ProductDetails> UpdateProductDetails(ProductDetails objProductDetails)
        {
            _productDetailsDbContext.Entry(objProductDetails).State=EntityState.Modified;
            await _productDetailsDbContext.SaveChangesAsync();
            return objProductDetails;
        }

        [HttpDelete]
        [Route("DeleteProductDetails/{id}")]
        public bool DeleteProductDetails(int id)
        {
            bool a = false;
            var productdetails = _productDetailsDbContext.ProductDetails.Find(id);
            if (productdetails != null)
            {
                a = true;
                _productDetailsDbContext.Entry(productdetails).State=EntityState.Deleted;
                _productDetailsDbContext.SaveChanges();
            }
            else
            {
                a= false;
            }
            return a;
        }

    }




}
