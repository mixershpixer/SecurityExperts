using SE.DAL.Entities;
using System;
using System.Threading.Tasks;

namespace SE.DAL.Interfaces
{
    public interface IRatingRepository : IBaseRepository<Rating>
    {
        Task RateMaterial(Guid userId, Guid materialId, int rating);
        Task<double> GetRating(Guid materialId);
    }
}
