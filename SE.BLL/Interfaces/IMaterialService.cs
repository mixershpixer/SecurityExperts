using SE.Common;
using SE.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SE.BLL.Interfaces
{
    public interface IMaterialService
    {
        Task<IEnumerable<MaterialViewModel>> GetAll();
        Task<bool> NewMaterial(MaterialViewModel material);
        Task DownloadMaterial(Guid id);
        Task<EducatorsMaterialsViewModel> GetMaterials(
            string searchText = null, 
            Enums.Auditory auditory = Enums.Auditory.Common, 
            Enums.Theme theme = Enums.Theme.Common, 
            Enums.Type type = Enums.Type.Common,
            Enums.MaterialStatus status = Enums.MaterialStatus.Published, int page = 1);
        Task ChangeStatus(Guid id, Enums.MaterialStatus status);
    }
}
