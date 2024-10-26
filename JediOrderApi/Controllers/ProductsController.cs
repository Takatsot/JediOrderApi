using JediOrderApi.Data;
using JediOrderApi.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using JediOrderApi.Models.DTO;
using JediOrderApi.Repository;
using JediOrderApi.CustomActionFilters;
using Microsoft.AspNetCore.Authorization;

namespace JediOrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {     
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository  = productRepository;
            _mapper             = mapper;
        }

        /// <summary>
        /// Get all products.
        /// GET:/api/products?filterOn=Name&filterQuery=Coca&sortBy=name&isAscending=true&pageNumber=1&pageSize=10
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] string? filterOn, [FromQuery] string? filterQuery, 
            [FromQuery] string? sortBy, [FromQuery] bool? isAscending, [FromQuery] int pageNumber = 1,[FromQuery] int pageSize = 100)
        {
            List<Products> products = await _productRepository.GetAllAsync(filterOn,filterQuery,sortBy,isAscending ?? true
                                                                            ,pageNumber,pageSize);
            return Ok(_mapper.Map<List<ProductsResponse>>(products));
        }

        /// <summary>
        /// Get single product by Id.
        /// GET: https://localhost:portnumber/api/products/{id}
        /// </summary>
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetProductByIdAsync([FromRoute] int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);

            if (product == null)
            {
                return NotFound(new { Message = "Product not found." });
            }

            ProductsResponse productResponse = _mapper.Map<ProductsResponse>(product);
            return Ok(productResponse);
        }

        /// <summary>
        /// Creates a product .
        /// POST: https://localhost:portnumber/api/products
        /// </summary>
        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> CreateAsync([FromForm] AddProductRequest request)
        {     
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // Map request to product entity
            Products product = _mapper.Map<Products>(request);
            // Save product to repository
            product = await _productRepository.CreateAsync(product);
            ProductsResponse productResponse = _mapper.Map<ProductsResponse>(product);

            return CreatedAtAction(nameof(GetProductByIdAsync), new { id = productResponse.ProductsID }, productResponse);
        }

        /// <summary>
        /// Update a product .
        /// PUT: https://localhost:portnumber/api/products/{id}
        /// </summary>
        [HttpPut]
        [Route("{id:int}")]
        [ValidateModel]
        public async Task<IActionResult> UpdateAsync([FromRoute] int id, [FromBody] AddProductRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Products product = _mapper.Map<Products>(request);

            Products? updatedProduct = await _productRepository.UpdateAsync(id, product);

            if (updatedProduct == null)
            {
                return NotFound(new { Message = "Product not found." });
            }

            ProductsResponse productResponse = _mapper.Map<ProductsResponse>(product);

            return Ok(productResponse);
        }


        /// <summary>
        /// Delete a product .
        /// DELETE: https://localhost:portnumber/api/products/{id}
        /// </summary>
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            Products? product = await _productRepository.DeleteAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ProductsResponse productResponse = _mapper.Map<ProductsResponse>(product);
            return Ok(productResponse);
        }

        #region Helper Methods
        // Helper method to create and save image entity
        private async Task<Images> CreateImageEntityAsync(ImageUploadRequest imageRequest, string userCreated)
        {
            // Initialize image entity with details from imageRequest
            Images image = new Images
            {
                Id = 1,//Guid.NewGuid(),
                FileName = imageRequest.FileName ?? imageRequest?.File?.FileName!,
                Description = imageRequest.Description,
                Extension = Path.GetExtension(imageRequest.File?.FileName!),
                SizeInBytes = imageRequest.File.Length,
                Path = Path.Combine("images", Guid.NewGuid().ToString() + Path.GetExtension(imageRequest.File.FileName)),
                UserCreated = userCreated,
                UserModified = userCreated,
                IsRetired = false,
                File = imageRequest.File,
            };

            // Save file to the specified directory
            Directory.CreateDirectory("images"); // Ensure directory exists
            using (var stream = new FileStream(image.Path, FileMode.Create))
            {
                await imageRequest.File.CopyToAsync(stream);
            }

            return image;
        }
        #endregion

        #region Validations
        private void ValidateFileUpload(ImageUploadRequest request)
        {
            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png" };
            if (!allowedExtensions.Contains(Path.GetExtension(request?.File?.FileName)))
            {
                ModelState.AddModelError("file", "Unsuported file extention");
            }
            if (request?.File?.Length > 10485760)
            {
                ModelState.AddModelError("file", "File size more than 10MB, please upload a smaller size file.");
            }
        }
        #endregion
    }
}
