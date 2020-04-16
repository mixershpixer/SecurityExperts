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

        public async Task<IEnumerable<MaterialViewModel>> GetMaterials(
            string searchText = null, Enums.Auditory auditory = Enums.Auditory.Common, Enums.Type type = Enums.Type.Common, int page = 1)
        {
            var pageCapacity = 2;

            var materials = await _unitOfWork.Materials.GetAll(m => m.Status == Enums.MaterialStatus.Published);
            materials = materials.ToList();
            if (auditory != Enums.Auditory.Common)
                materials = materials.Where(m => m.Auditory == auditory).ToList();

            if (type != Enums.Type.Common)
                materials = materials.Where(m => m.Type == type).ToList();
            
            if (!String.IsNullOrEmpty(searchText))
                materials = materials.Where(m => 
                m.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                m.Description.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                m.Theme.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);

            materials = materials.Skip(0).Take(pageCapacity * page);

            return materials.Select(m => new MaterialViewModel
            {
                Id = m.Id,
                Name = m.Name,
                UserId = m.UserId,
                AuthorEmail = _unitOfWork.Users.GetUserById(m.UserId).Email,
                Description = m.Description,
                Status = m.Status,
                PublishingDate = m.PublishingDate,
                PublishingDateString = m.PublishingDate.ToString("dd.MM.yyyy"),
                Auditory = m.Auditory,
                Theme = m.Theme,
                Type = m.Type,
                TypeString = m.Type.ToString("d"),
                DownloadingLink = m.DownloadingLink,
                BytePicture = m.Picture,
                Base64Picture = Convert.ToBase64String(m.Picture),
                SourceOfInformation = m.SourceOfInformation,
                Rating = m.Rating,
                DownloadsCount = m.DownloadsCount
            }); 
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
