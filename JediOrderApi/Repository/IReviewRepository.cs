using JediOrderApi.Models.Domain;

namespace JediOrderApi.Repository
{
    public interface IReviewRepository
    {
        Task<List<Reviews>> GetAllAsync();
        Task<Reviews?> GetByIdAsync(int id);
        Task<Reviews> CreateAsync(Reviews review);
        Task<Reviews?> UpdateAsync(int id, Reviews review);
        Task<Reviews?> DeleteAsync(int id);
    }
}
