using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SE.BLL.Interfaces;
using SE.Common;
using SE.Model.ViewModels;

namespace SE.WebSite.Controllers
{
    public class MaterialController : BaseController
    {
        public MaterialController(
            ICommentService CommentService,
            IDownloadingService DownloadingService,
            IMaterialService MaterialService,
            IRatingService RatingService,
            IUserService UserService) : base(
                CommentService,
                DownloadingService,
                MaterialService,
                RatingService,
                UserService)
        {
        }

        [HttpGet]
        public IActionResult EducatorsHome()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EducatorsMaterials(int theme)
        {
            var educatorsMaterialsViewModel = await MaterialService.GetMaterials(null, Enums.Auditory.Teachers, (Enums.Theme)theme);

            return View(educatorsMaterialsViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EducatorsHomeSearch(EducatorsMaterialsViewModel model)
        {
            var educatorsMaterialsViewModel = await MaterialService.GetMaterials(model.SearchText, Enums.Auditory.Teachers, model.Theme, model.Type, Enums.MaterialStatus.Published, model.Page);

            return Json(educatorsMaterialsViewModel);
        }

        [HttpGet]
        public IActionResult ParentsHome()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewMaterial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewMaterial(MaterialViewModel model)
        {
            model.UserId = await UserService.GetUserIdByEmail(User.Identity.Name);

            var result = await MaterialService.NewMaterial(model);

            if(result)
                return RedirectToAction("Index", "Home");
            else
                ModelState.AddModelError(string.Empty, "Что-то пошло не так, попробуйте снова");

            return View();
        }

        [HttpGet]
        public async Task DownloadMaterial(Guid id)
        {
            await MaterialService.DownloadMaterial(id);
        }
    }
}
