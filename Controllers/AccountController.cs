using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;

namespace JenkinsIntegration.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
                return Challenge(OpenIdConnectDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}