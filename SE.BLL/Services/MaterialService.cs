using SE.BLL.Interfaces;
using SE.Common;
using SE.DAL.Entities;
using SE.DAL.Interfaces;
using SE.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.BLL.Services
{
    public class MaterialService : IMaterialService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MaterialService(
            IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task ChangeStatus(Guid id, Enums.MaterialStatus status)
        {
            var material = await _unitOfWork.MaterialRepository.GetByPredicate(m => m.Id == id);
            material.Status = status;
            material.PublishingDate = DateTime.Now;

            await _unitOfWork.SaveAsync();
        }

        public async Task DownloadMaterial(Guid id)
        {
            var material = await _unitOfWork.MaterialRepository.GetByPredicate(m => m.Id == id);
            material.DownloadsCount += 1;

            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<MaterialViewModel>> GetAll()
        {
            var materials = await _unitOfWork.MaterialRepository.GetAll();
            return materials.ToList().Select(m => new MaterialViewModel
            {
                Id = m.Id,
                Name = m.Name,
                UserId = m.UserId,
                AuthorEmail = _unitOfWork.UserRepository.GetUserById(m.UserId).Email,
                Description = m.Description,
                PublishingDate = m.PublishingDate,
                PublishingDateString = m.PublishingDate.ToString("dd.MM.yyyy"),
                Auditory = m.Auditory,
                Status = m.Status,
                StatusString = Constants.Status[(int)m.Status],
                Theme = m.Theme,
                ThemeString = Constants.Theme[(int)m.Theme],
                Type = m.Type,
                TypeString = Constants.Type[(int)m.Type],
                DownloadingLink = m.DownloadingLink,
                BytePicture = m.Picture,
                Base64Picture = Convert.ToBase64String(m.Picture),
                SourceOfInformation = m.SourceOfInformation,
                Rating = m.Rating,
                DownloadsCount = m.DownloadsCount
            });
        }

        public async Task<MaterialViewModel> GetById(Guid id)
        {
            var m = await _unitOfWork.MaterialRepository.GetByPredicate(m => m.Id == id);

            var comments = await _unitOfWork.CommentRepository.GetMaterialComments(id);

            return new MaterialViewModel
            {
                Id = m.Id,
                Name = m.Name,
                UserId = m.UserId,
                AuthorEmail = _unitOfWork.UserRepository.GetUserById(m.UserId).Email,
                AuthorName = _unitOfWork.UserRepository.GetUserById(m.UserId).Name,
                AuthorSurname = _unitOfWork.UserRepository.GetUserById(m.UserId).Surname,
                Description = m.Description,
                PublishingDate = m.PublishingDate,
                PublishingDateString = m.PublishingDate.ToString("dd.MM.yyyy hh:mm"),
                Status = m.Status,
                StatusString = Constants.Status[(int)m.Status],
                Auditory = m.Auditory,
                Theme = m.Theme,
                ThemeString = Constants.Theme[(int)m.Theme],
                Type = m.Type,
                TypeString = Constants.Type[(int)m.Type],
                DownloadingLink = m.DownloadingLink,
                BytePicture = m.Picture,
                Base64Picture = Convert.ToBase64String(m.Picture),
                SourceOfInformation = m.SourceOfInformation,
                Rating = Math.Round(m.Rating, 1),
                DownloadsCount = m.DownloadsCount,
                Comments = comments.Select(c => new CommentViewModel
                {
                    CommentId = c.Id,
                    UserId = c.UserId,
                    UserName = c.User.Name,
                    UserSurname = c.User.Surname,
                    UserEmail = c.User.Email,
                    MaterialId = c.MaterialId,
                    CommentText = c.Text,
                    CommentDate = c.Date.ToString("HH:mm dd-MM-yy")
                }).OrderByDescending(c => c.CommentDate).ToList()
            };
        }

        public async Task<MaterialsCollectionViewModel> GetMaterials(
            string searchText = null, Enums.Auditory auditory = Enums.Auditory.Common,
            Enums.Theme theme = Enums.Theme.Common,
            Enums.Type type = Enums.Type.Common,
            Enums.MaterialStatus status = Enums.MaterialStatus.All, int page = 0,
            Guid? userId = null, Enums.SortType sortType = Enums.SortType.AlphabetAsc,
            int count = 3)
        {
            var materials = await _unitOfWork.MaterialRepository.GetAll();
            materials = materials.ToList();

            if (status != Enums.MaterialStatus.All)
                materials = materials.Where(m => m.Status == status).ToList();

            if (auditory != Enums.Auditory.Common)
                materials = materials.Where(m => m.Auditory == auditory).ToList();

            if (type != Enums.Type.Common)
                materials = materials.Where(m => m.Type == type).ToList();

            if (theme != Enums.Theme.Common)
                materials = materials.Where(m => m.Theme == theme).ToList();

            if (!string.IsNullOrEmpty(searchText))
                materials = materials.Where(m =>
                m.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                m.Description.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                m.Theme.ToString("d").IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);

            if (userId != null)
                materials = materials.Where(m => m.UserId == userId).ToList();

            if (sortType == Enums.SortType.AlphabetAsc)
                materials = materials.OrderBy(m => m.Name).ToList();
            else if (sortType == Enums.SortType.AlphabetDesc)
                materials = materials.OrderByDescending(m => m.Name).ToList();
            else if (sortType == Enums.SortType.DateAsc)
                materials = materials.OrderBy(m => m.PublishingDate).ToList();
            else if (sortType == Enums.SortType.DateDesc)
                materials = materials.OrderByDescending(m => m.PublishingDate).ToList();
            else if (sortType == Enums.SortType.RateAsc)
                materials = materials.OrderByDescending(m => m.Rating).ToList();

            var materialsCount = materials.Count();

            if (page != 0)
                materials = materials.Skip(0).Take(count * page);

            var uiMaterials = materials.Select(m => new MaterialViewModel
            {
                Id = m.Id,
                Name = m.Name,
                UserId = m.UserId,
                AuthorEmail = _unitOfWork.UserRepository.GetUserById(m.UserId).Email,
                AuthorName = _unitOfWork.UserRepository.GetUserById(m.UserId).Name,
                AuthorSurname = _unitOfWork.UserRepository.GetUserById(m.UserId).Surname,
                Description = m.Description,
                PublishingDate = m.PublishingDate,
                PublishingDateString = m.PublishingDate.ToString("dd.MM.yyyy"),
                Status = m.Status,
                StatusString = Constants.Status[(int)m.Status],
                Auditory = m.Auditory,
                Theme = m.Theme,
                ThemeString = Constants.Theme[(int)m.Theme],
                Type = m.Type,
                TypeString = Constants.Type[(int)m.Type],
                DownloadingLink = m.DownloadingLink,
                BytePicture = m.Picture,
                Base64Picture = Convert.ToBase64String(m.Picture),
                SourceOfInformation = m.SourceOfInformation,
                Rating = m.Rating,
                DownloadsCount = m.DownloadsCount
            });

            return new MaterialsCollectionViewModel
            {
                SearchText = searchText,
                Type = type,
                Theme = theme,
                ThemeString = Constants.Theme[(int)theme],
                Materials = uiMaterials,
                Page = page,
                TotalCount = materialsCount
            };
        }

        public async Task<bool> NewMaterial(MaterialViewModel material)
        {
            byte[] imageData = null;
            using (var binaryReader = new BinaryReader(material.Picture.OpenReadStream()))
            {
                imageData = binaryReader.ReadBytes((int)material.Picture.Length);
            }

            var addedMaterial = await _unitOfWork.MaterialRepository.InsertAsync(new Material
            {
                Id = Guid.NewGuid(),
                Name = material.Name,
                UserId = material.UserId,
                Description = material.Description,
                Status = Enums.MaterialStatus.OnModeration,
                PublishingDate = DateTime.Now,
                Auditory = Enums.Auditory.Educators,
                Theme = material.Theme,
                Type = material.Type,
                DownloadingLink = material.DownloadingLink,
                Picture = imageData,
                SourceOfInformation = material.SourceOfInformation != String.Empty ? material.SourceOfInformation : "Оригинальный материал",
                Rating = 0,
                DownloadsCount = 0
            });

            return addedMaterial != null ? true : false;
        }
    }
}
