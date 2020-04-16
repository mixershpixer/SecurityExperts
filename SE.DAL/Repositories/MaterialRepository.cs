using SE.DAL.Entities;
using SE.DAL.Interfaces;

namespace SE.DAL.Repositories
{
    public class MaterialRepository : BaseRepository<Material>, IMaterialRepository
    {
        public MaterialRepository(SEContext context) : base(context)
        {
        }
    }
}
