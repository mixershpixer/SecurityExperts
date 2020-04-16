using SE.Common;
using SE.Model.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SE.BLL.Interfaces
{
    public interface IMaterialService
    {
        Task<bool> NewMaterial(MaterialViewModel material);

        Task<IEnumerable<MaterialViewModel>> GetMaterials(string searchText = null, Enums.Auditory auditory = Enums.Auditory.Common, Enums.Type type = Enums.Type.Common, int page = 1); 
    }
}
