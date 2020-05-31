using Microsoft.AspNetCore.Mvc;

namespace SE.WebSite.Controllers
{
    public class ErrorController : Controller
    {

        public ErrorController()
        {
        }
        
        [Route("Error/500")]
        public IActionResult AppError()
        {
            return View();
        }

        [Route("Error/404")]
        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}