using Microsoft.EntityFrameworkCore;
using SE.DAL.Entities;
using SE.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SE.DAL.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(SEContext context) : base(context)
        {
        }

        public async Task<Comment> AddComment(Guid userId, Guid materialId, string commentText, DateTime date)
        {
            var comment = await DbSet.AddAsync(new Comment
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                MaterialId = materialId,
                Date = date,
                Text = commentText,
            });

            await Context.SaveChangesAsync();

            return await DbSet.Where(c => c.UserId == userId && c.MaterialId == materialId && c.Date == date).FirstOrDefaultAsync();
        }

        public async Task<bool> DeleteComment(Guid commentId)
        {
            var comment = DbSet.Where(c => c.Id == commentId).FirstOrDefault();
            DbSet.Remove(comment);
            await Context.SaveChangesAsync();
            return !DbSet.Any(c => c.Id == commentId);
        }

        public async Task<IEnumerable<Comment>> GetMaterialComments(Guid materialId)
        {
            var comments = await DbSet
                .Include(c => c.User)
                .Include(c => c.Material)
                .Where(c => c.MaterialId == materialId)
                .ToListAsync();

            return comments;
        }
    }
}
