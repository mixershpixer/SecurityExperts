using SE.DAL.Entities;
using SE.DAL.Interfaces;

namespace SE.DAL.Repositories
{
    public class RatingRepository : BaseRepository<Rating>, IRatingRepository
    {
        public RatingRepository(SEContext context) : base(context)
        {
        }
    }
}
