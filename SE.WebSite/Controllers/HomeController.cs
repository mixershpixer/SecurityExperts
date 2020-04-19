using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SE.BLL.Interfaces;
using SE.Common;
using SE.Model.ViewModels;
using SE.WebSite.Models;

namespace SE.WebSite.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public async Task<IActionResult> PersonalAccount()
        {
            var educatorsMaterialsViewModel = await MaterialService.GetMaterials(
                searchText: null, auditory: Enums.Auditory.Common, theme: Enums.Theme.Common,
                type: Enums.Type.Common, page: 0,
                userId: await UserService.GetUserIdByEmail(User.Identity.Name));

            return View(educatorsMaterialsViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> PersonalAccount(MaterialsCollectionViewModel model)
        {
            var educatorsMaterialsViewModel = await MaterialService.GetMaterials(
                searchText: null, auditory: Enums.Auditory.Common, theme: Enums.Theme.Common, 
                type: Enums.Type.Common, status: model.MaterialStatus, page: 0, 
                userId: await UserService.GetUserIdByEmail(User.Identity.Name), sortType: model.SortType);

            return Json(educatorsMaterialsViewModel);
        }


        public async Task<IActionResult> AddComment(CommentViewModel model)
        {
            var user = await UserService.GetUserByEmail(User.Identity.Name);
            var comment = await CommentService.AddComment(user.UserId, model.MaterialId, model.CommentText, /*model.Rating*/ 5);
            return Ok(comment);
        }

        public async Task<IActionResult> DeleteComment(Guid commentId)
        {
            if (await CommentService.DeleteComment(commentId))
                return Ok(commentId);
            else return BadRequest();
        }

        public IActionResult ChildrenLie()
        {
            return View("ParentsStatic/ChildrenLie");
        }
    }
}
