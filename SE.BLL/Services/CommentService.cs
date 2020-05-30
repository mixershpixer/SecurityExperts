using SE.BLL.Interfaces;
using SE.DAL.Interfaces;
using SE.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SE.BLL.Services
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentService(
            IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CommentViewModel> AddComment(Guid userId, Guid materialId, string commentText)
        {
            var comment = await _unitOfWork.CommentRepository.AddComment(userId, materialId, commentText, DateTime.Now);

            return new CommentViewModel
            {
                CommentId = comment.Id,
                CommentDate = comment.Date.ToString("HH:mm dd-MM-yy"),
                CommentText = comment.Text,
                UserId = comment.User.Id,
                UserEmail = comment.User.Email,
                UserName = comment.User.Name,
                UserSurname = comment.User.Surname,
                MaterialId = comment.MaterialId
            };
        }

        public async Task<bool> DeleteComment(Guid commentId)
        {
            return await _unitOfWork.CommentRepository.DeleteComment(commentId);
        }
    }
}
