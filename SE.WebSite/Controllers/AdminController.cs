﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SE.BLL.Interfaces;
using SE.Common;

namespace SE.WebSite.Controllers
{
    public class UsersViewComponent : ViewComponent
    {
        private readonly IUserService _userService;
        public UsersViewComponent(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var users = await _userService.GetAll();
            return View("AdminUsers", users);
        }
    }
    public class MaterialsViewComponent : ViewComponent
    {
        private readonly IMaterialService _materialService;
        public MaterialsViewComponent(IMaterialService materialService)
        {
            _materialService = materialService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var materials = await _materialService.GetAll();
            return View("AdminMaterials", materials);
        }
    }

    //[Authorize(Roles = "Admin")]
    public class AdminController : BaseController
    {
        public AdminController(
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


        [HttpGet]
        public async Task<IActionResult> GetMaterialsWithOptions(int status, int page)
        {
            var model = await MaterialService.GetMaterials(status: (Enums.MaterialStatus)status, page: page);

            model.Materials.OrderByDescending(m => m.PublishingDate);

            return Ok(model);
        }


        [HttpGet]
        public async Task<IActionResult> ApproveMaterial(Guid id)
        {
            await MaterialService.ChangeStatus(id, Enums.MaterialStatus.Published);

            var model = await MaterialService.GetMaterials(status: Enums.MaterialStatus.OnModeration, page: 0);

            model.Materials.OrderByDescending(m => m.PublishingDate);

            return Ok(model);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteMaterial(Guid id)
        {
            await MaterialService.ChangeStatus(id, Enums.MaterialStatus.Deleted);

            var model = await MaterialService.GetMaterials(status: Enums.MaterialStatus.OnModeration, page: 0);

            model.Materials.OrderByDescending(m => m.PublishingDate);

            return Ok(model);
        }

        [HttpGet]
        public async Task<IActionResult> RestoreMaterial(Guid id)
        {
            await MaterialService.ChangeStatus(id, Enums.MaterialStatus.Published);

            var model = await MaterialService.GetMaterials(status: Enums.MaterialStatus.Deleted, page: 0);

            model.Materials.OrderByDescending(m => m.PublishingDate);

            return Ok(model);
        }
    }
}