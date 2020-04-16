using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SE.BLL.Interfaces;
using SE.Model.ViewModels;
using SE.WebSite.Email;

namespace SE.WebSite.Controllers
{
    public class AccountController : BaseController
    {
        private EmailSettings EmailSettings { get; set; }

        public AccountController(
            ICommentService CommentService,
            IDownloadingService DownloadingService,
            IMaterialService MaterialService,
            IRatingService RatingService,
            IUserService UserService, 
            IOptions<EmailSettings> settings) : base(
                CommentService,
                DownloadingService,
                MaterialService,
                RatingService,
                UserService)
        {
            EmailSettings = settings.Value;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var logmodel = await UserService.Login(model);
            if (logmodel.Message != null)
                return View(logmodel);
            if (!await UserService.IsConfirmed(logmodel.Email))
                return RedirectToAction("Confirm", "Account", new { logmodel.UserId, logmodel.Email });
            await Authenticate(model.Email);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View(new RegistrationViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var regmodel = await UserService.Registration(model);
            if (regmodel.Message != null)
                return View(regmodel);

            return RedirectToAction("Confirm", "Account", new { regmodel.UserId, regmodel.Email });
        }

        [AllowAnonymous]
        public async Task<ActionResult> Confirm(Guid userId, string email)
        {
            if (!await UserService.IsConfirmed(email))
            {
                var body = string.Format("{0}: {1}", "You need to confirm email using this link",
                    Url.Action("ConfirmEmail", "Account", new { token = userId, email }, Request.Scheme));
                EmailService emailService = new EmailService();
                await emailService.SendConfirmationEmailAsync(email, body, EmailSettings.AdminEmailAdress, EmailSettings.AdminEmailPassword);

                ViewData["Message"] = string.Format("{0}{1}{2}", "Мы отправили вам письмо для подтверждения вашей электронной почты", Environment.NewLine, email);
                return View();
            }
            else
                return RedirectToAction("Login", "Account");
        }

        [AllowAnonymous]
        public async Task<ActionResult> ConfirmEmail(Guid token, string Email)
        {
            var user = await UserService.GetUserById(token);
            if (user == null)
                return RedirectToAction("Confirm", "Account", new { Email });
            if (user.Email != Email)
                return RedirectToAction("Confirm", "Account", new { user.Email });
            UserService.ConfirmEmail(Email);
            return RedirectToAction("Login", "Account");
        }

        private async Task Authenticate(string userName)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, UserService.GetRole(userName))
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
