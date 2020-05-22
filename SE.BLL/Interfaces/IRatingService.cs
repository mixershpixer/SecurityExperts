using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SE.BLL.Interfaces
{
    public interface IRatingService
    {
        Task RateMaterial(Guid userId, Guid materialId, int rating);
        Task<double> GetRating(Guid materialId);
    }
}
