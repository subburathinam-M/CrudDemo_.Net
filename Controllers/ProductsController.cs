using Microsoft.AspNetCore.Mvc;
using CrudDemo.Models;
using Microsoft.EntityFrameworkCore;
using CrudDemo.Data;

namespace CrudDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/products

        
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        // {
        //     return await _context.Products.ToListAsync();
        // }

        [HttpGet]
        public async Task<ActionResult<object>> GetProducts()
        {
            try
            {
                var products = await _context.Products.ToListAsync();

                return Ok(new
                {
                    message = "Products retrieved successfully",
                    count = products.Count,
                    data = products
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    message = "Error retrieving products",
                    error = ex.Message
                });
            }
        }


        // GET: api/products/5


        // [HttpGet("{id}")]
        // public async Task<ActionResult<Product>> GetProduct(int id)
        // {
        //     var product = await _context.Products.FindAsync(id);

        //     if (product == null)
        //     {
        //         return NotFound();
        //     }

        //     return product;
        // }


        [HttpGet("{id}")]
        public async Task<ActionResult<object>> GetProduct(int id)
        {
            try
            {
                var product = await _context.Products.FindAsync(id);

                if (product == null)
                {
                    return NotFound(new
                    {
                        message = "Product not found",
                        productId = id
                    });
                }

                return Ok(new
                {
                    message = "Product retrieved successfully",
                    data = product
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    message = "Error retrieving product",
                    error = ex.Message
                });
            }
        }


        // POST: api/products


        [HttpPost]
        public async Task<ActionResult<object>> CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetProduct),
                new { id = product.Id },
                new
                {
                    message = "Product created successfully",
                    product = product
                }
            );
        }

        // [HttpPost]
        // public async Task<ActionResult<Product>> CreateProduct(Product product)
        // {
        //     _context.Products.Add(product);
        //     await _context.SaveChangesAsync();

        //     return CreatedAtAction(
        //         nameof(GetProduct),
        //         new { id = product.Id },
        //         product);
        // }

        // PUT: api/products/5

        // [HttpPut("{id}")]
        // public async Task<IActionResult> UpdateProduct(int id, Product product)
        // {
        //     if (id != product.Id)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(product).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!_context.Products.Any(e => e.Id == id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product product)
        {
            var existingProduct = await _context.Products.FindAsync(id);
            if (existingProduct == null)
            {
                return NotFound(new { message = "Product not found" });
            }

            // Update only the fields you want
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Product updated successfully",
                updatedProduct = existingProduct
            });
        }



        // DELETE: api/products/5
        
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeleteProduct(int id)
        // {
        //     var product = await _context.Products.FindAsync(id);
        //     if (product == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.Products.Remove(product);
        //     await _context.SaveChangesAsync();

        //     return NoContent();
        // }


        [HttpDelete("{id}")]
public async Task<IActionResult> DeleteProduct(int id)
{
    try
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
        {
            return NotFound(new { 
                message = "Product not found",
                productId = id 
            });
        }

        _context.Products.Remove(product);
        await _context.SaveChangesAsync();

        return Ok(new {
            message = "Product deleted successfully",
            deletedProduct = new {
                id = product.Id,
                name = product.Name,
                price = product.Price
            }
        });
    }
    catch (Exception ex)
    {
        return BadRequest(new { 
            message = "Error deleting product", 
            error = ex.Message 
        });
    }
}

    }
}
