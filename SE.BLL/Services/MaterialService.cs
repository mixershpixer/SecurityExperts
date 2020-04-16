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
            var material = await _unitOfWork.Materials.GetByPredicate(m => m.Id == id);
            material.Status = status;

            await _unitOfWork.SaveAsync();
        }

        public async Task DownloadMaterial(Guid id)
        {
            var material = await _unitOfWork.Materials.GetByPredicate(m => m.Id == id);
            material.DownloadsCount += 1;

            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<MaterialViewModel>> GetAll()
        {
            var materials = await _unitOfWork.Materials.GetAll();
            return materials.ToList().Select(m => new MaterialViewModel
            {
                Id = m.Id,
                Name = m.Name,
                UserId = m.UserId,
                AuthorEmail = _unitOfWork.Users.GetUserById(m.UserId).Email,
                Description = m.Description,
                Status = m.Status,
                StatusString = m.Status.ToString(),
                PublishingDate = m.PublishingDate,
                PublishingDateString = m.PublishingDate.ToString("dd.MM.yyyy"),
                Auditory = m.Auditory,
                Theme = m.Theme,
                ThemeString = m.Theme.ToString(),
                Type = m.Type,
                TypeString = m.Type.ToString(),
                DownloadingLink = m.DownloadingLink,
                BytePicture = m.Picture,
                Base64Picture = Convert.ToBase64String(m.Picture),
                SourceOfInformation = m.SourceOfInformation,
                Rating = m.Rating,
                DownloadsCount = m.DownloadsCount
            });
        }

        public async Task<EducatorsMaterialsViewModel> GetMaterials(
            string searchText = null, Enums.Auditory auditory = Enums.Auditory.Common, 
            Enums.Theme theme = Enums.Theme.Common,
            Enums.Type type = Enums.Type.Common,
            Enums.MaterialStatus status = Enums.MaterialStatus.All, int page = 0)
        {
            var pageCapacity = 3;

            var materials = await _unitOfWork.Materials.GetAll();
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

            var count = materials.Count();

            if(page != 0)
                materials = materials.Skip(0).Take(pageCapacity * page);

            var uiMaterials = materials.Select(m => new MaterialViewModel
            {
                Id = m.Id,
                Name = m.Name,
                UserId = m.UserId,
                AuthorEmail = _unitOfWork.Users.GetUserById(m.UserId).Email,
                Description = m.Description,
                PublishingDate = m.PublishingDate,
                PublishingDateString = m.PublishingDate.ToString("dd.MM.yyyy"),
                Status = m.Status,
                StatusString = m.Status.ToString(),
                Auditory = m.Auditory,
                Theme = m.Theme,
                ThemeString = m.Theme.ToString(),
                Type = m.Type,
                TypeString = m.Type.ToString(),
                DownloadingLink = m.DownloadingLink,
                BytePicture = m.Picture,
                Base64Picture = Convert.ToBase64String(m.Picture),
                SourceOfInformation = m.SourceOfInformation,
                Rating = m.Rating,
                DownloadsCount = m.DownloadsCount
            });

            return new EducatorsMaterialsViewModel
            {
                SearchText = searchText,
                Type = type,
                Theme = theme,
                Materials = uiMaterials,
                Page = page,
                TotalCount = count
            };
        }

        public async Task<bool> NewMaterial(MaterialViewModel material)
        {
            byte[] imageData = null;
            using (var binaryReader = new BinaryReader(material.Picture.OpenReadStream()))
            {
                imageData = binaryReader.ReadBytes((int)material.Picture.Length);
            }

            var addedMaterial = await _unitOfWork.Materials.InsertAsync(new Material
            {
                Id = Guid.NewGuid(),
                Name = material.Name,
                UserId = material.UserId,
                Description = material.Description,
                Status = Enums.MaterialStatus.OnModeration,
                PublishingDate = DateTime.Now,
                Auditory = material.Auditory,
                Theme = material.Theme,
                Type = material.Type,
                DownloadingLink = material.DownloadingLink,
                Picture = imageData,
                SourceOfInformation = material.SourceOfInformation,
                Rating = 0,
                DownloadsCount = 0
            });

            return addedMaterial != null ? true : false;
        }
    }
}
