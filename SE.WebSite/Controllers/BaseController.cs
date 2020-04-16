using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SE.BLL.Interfaces;

namespace SE.WebSite.Controllers
{
    public class BaseController : Controller
    {
        public ICommentService CommentService { get; set; }
        public IDownloadingService DownloadingService { get; set; }
        public IMaterialService MaterialService { get; set; }
        public IRatingService RatingService { get; set; }
        public IUserService UserService{ get; set; }

        public BaseController(
            ICommentService commentService,
            IDownloadingService downloadingService,
            IMaterialService materialService,
            IRatingService ratingService,
            IUserService userService)
        {
            CommentService = commentService;
            DownloadingService = downloadingService;
            MaterialService = materialService;
            RatingService = ratingService;
            UserService = userService;
        }
    }
}
