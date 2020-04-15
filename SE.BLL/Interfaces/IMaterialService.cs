using SE.Model.ViewModels;
using System.Threading.Tasks;

namespace SE.BLL.Interfaces
{
    public interface IMaterialService
    {
        Task<bool> NewMaterial(MaterialViewModel material);
    }
}
