using JediOrderApi.Data;
using JediOrderApi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace JediOrderApi.Repository
{
    public class SqlReviewRepository : IReviewRepository
    {
        private readonly JediOrderDbContext _dbContext;

        public SqlReviewRepository(JediOrderDbContext jediOrderDbContext)
        {
            this._dbContext = jediOrderDbContext;
        }

        #region Get Methods
        public async Task<List<Reviews>> GetAllAsync()
        {
            return await _dbContext.Review.Include("Products").ToListAsync();
        }
        public async Task<Reviews?> GetByIdAsync(int id)
        {
            return await _dbContext.Review.Include("Products").FirstOrDefaultAsync(x => x.Id == id);
        }
        #endregion

        #region Modify Methods
        public async Task<Reviews> CreateAsync(Reviews review)
        {
            await _dbContext.Review.AddAsync(review);
            await _dbContext.SaveChangesAsync();
            return review;
        }

        public async Task<Reviews?> UpdateAsync(int id, Reviews review)
        {
            Reviews? existingReviews = await _dbContext.Review.FirstOrDefaultAsync(x => x.Id == id);

            if (existingReviews == null)
            {
                return null;
            }

            GetUpdatedEntity(existingReviews, review);
            await _dbContext.SaveChangesAsync();

            return existingReviews;
        }

        public async Task<Reviews?> DeleteAsync(int id)
        {
            Reviews? existingReviews = await GetEntityAsync(id);

            if (existingReviews == null)
            {
                return null;
            }

            _dbContext.Review.Remove(existingReviews);
            await _dbContext.SaveChangesAsync();
            return existingReviews;
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// returns an  product entity.
        /// </summary>
        private void GetUpdatedEntity(Reviews existingReview, Reviews review)
        {
            existingReview.ReviewTitle = review.ReviewTitle;
            existingReview.Comment = review.Comment;
            existingReview.DateModified = DateTime.Now;
            existingReview.UserModified = review.UserCreated;
        }

        /// <summary>
        /// Returns the product entity if found; otherwise, null.
        /// </summary>
        /// <param name="id">The ID of the product.</param>
        /// <returns>The product entity or null if not found.</returns>
        private async Task<Reviews?> GetEntityAsync(int id)
        {
            return await _dbContext.Review.FirstOrDefaultAsync(x => x.Id == id);
        }

        #endregion

    }
}
