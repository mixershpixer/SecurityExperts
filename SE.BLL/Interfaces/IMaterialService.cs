using SE.Common;
using SE.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SE.BLL.Interfaces
{
    public interface IMaterialService
    {
        Task<MaterialViewModel> GetById(Guid id);
        Task<IEnumerable<MaterialViewModel>> GetAll();
        Task<bool> NewMaterial(MaterialViewModel material);
        Task DownloadMaterial(Guid id);
        Task<MaterialsCollectionViewModel> GetMaterials(
            string searchText = null, 
            Enums.Auditory auditory = Enums.Auditory.Common, 
            Enums.Theme theme = Enums.Theme.Common, 
            Enums.Type type = Enums.Type.Common,
            Enums.MaterialStatus status = Enums.MaterialStatus.Published, int page = 1,
            Guid? userId = null, Enums.SortType sortType = Enums.SortType.AlphabetAsc, int count = 3);
        Task ChangeStatus(Guid id, Enums.MaterialStatus status);
    }
}
