using SE.BLL.Interfaces;
using SE.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SE.BLL.Services
{
    public class RatingService : IRatingService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RatingService(
            IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<double> GetRating(Guid materialId)
        {
            return _unitOfWork.RatingRepository.GetRating(materialId);
        }

        public async Task RateMaterial(Guid userId, Guid materialId, int rating)
        {
            await _unitOfWork.RatingRepository.RateMaterial(userId, materialId, rating);
        }
    }
}
