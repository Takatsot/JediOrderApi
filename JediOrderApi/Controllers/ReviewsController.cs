using AutoMapper;
using JediOrderApi.CustomActionFilters;
using JediOrderApi.Models.Domain;
using JediOrderApi.Models.DTO;
using JediOrderApi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JediOrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public ReviewsController(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all reviews.
        /// GET: https://localhost:portnumber/api/reviews
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            List<Reviews> reviews = await _reviewRepository.GetAllAsync();
            return Ok(_mapper.Map<List<ReviewResponse>>(reviews));
        }

        /// <summary>
        /// Get a single review by Id.
        /// GET: https://localhost:portnumber/api/reviews/{id}
        /// </summary>
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            var review = await _reviewRepository.GetByIdAsync(id);
            if (review == null)
            {
                return NotFound(new { Message = "Review not found." });
            }
            return Ok(_mapper.Map<ReviewResponse>(review));
        }

        /// <summary>
        /// Creates a review.
        /// POST: https://localhost:portnumber/api/reviews
        /// </summary>
        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> CreateAsync([FromBody] AddReviewsRequest request)
        {         
            Reviews review = _mapper.Map<Reviews>(request);
            review = await _reviewRepository.CreateAsync(review);
            ReviewResponse reviewResponse = _mapper.Map<ReviewResponse>(review);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = reviewResponse.ReviewsID }, reviewResponse);
        }

        /// <summary>
        /// Updates a review.
        /// PUT: https://localhost:portnumber/api/reviews/{id}
        /// </summary>
        [HttpPut]
        [Route("{id:int}")]
        [ValidateModel]
        public async Task<IActionResult> UpdateAsync([FromRoute] int id, [FromBody] AddReviewsRequest request)
        {
            Reviews review = _mapper.Map<Reviews>(request);

            Reviews? updatedReview = await _reviewRepository.UpdateAsync(id, review);

            if (updatedReview == null)
            {
                return NotFound();
            }

            ReviewResponse reviewResponse = _mapper.Map<ReviewResponse>(updatedReview);

            return Ok(reviewResponse);
        }

        /// <summary>
        /// Deletes a review.
        /// DELETE: https://localhost:portnumber/api/reviews/{id}
        /// </summary>
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            Reviews? review = await _reviewRepository.DeleteAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            ReviewResponse reviewResponse = _mapper.Map<ReviewResponse>(review);
            return Ok(reviewResponse);
        }
    }
}
