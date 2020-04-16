using SE.BLL.Interfaces;
using SE.Common;
using SE.DAL.Entities;
using SE.DAL.Interfaces;
using SE.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
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
