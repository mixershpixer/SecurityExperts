using Microsoft.EntityFrameworkCore;
using SE.DAL.Entities;
using SE.DAL.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SE.DAL.Repositories
{
    public class RatingRepository : BaseRepository<Rating>, IRatingRepository
    {
        public RatingRepository(SEContext context) : base(context)
        {
        }

        public async Task<double> GetRating(Guid materialId)
        {
            var rating = 0;

            var ratings = await DbSet.Where(r => r.MaterialId == materialId).ToListAsync();

            foreach (var r in ratings)
                rating += r.Value;

            return Math.Round((double)rating / ratings.Count(), 1);
        }

        public async Task RateMaterial(Guid userId, Guid materialId, int rating)
        {
            var material = await Context.Materials.FirstOrDefaultAsync(m => m.Id == materialId);

            if(material != null)
            {
                var rate = await DbSet.FirstOrDefaultAsync(r => r.MaterialId == materialId && r.UserId == userId);

                if (rate == null)
                    await DbSet.AddAsync(new Rating { MaterialId = materialId, UserId = userId, Value = rating });
                else
                    rate.Value = rating;

                await Context.SaveChangesAsync();

                var ratings = await DbSet.Where(r => r.MaterialId == materialId).ToListAsync();
                var result = 0;
                foreach (var r in ratings)
                    result += r.Value;

                material.Rating = Math.Round((double) result / ratings.Count(), 1);

                await Context.SaveChangesAsync();
            }
        }
    }
}
