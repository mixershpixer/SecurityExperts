using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SE.BLL.Interfaces;
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
    }
}
