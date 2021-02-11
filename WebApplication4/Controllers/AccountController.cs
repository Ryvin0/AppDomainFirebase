using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security.Cookies;
using Okta.AspNet;

namespace WebApplication4.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoginVw()
        {
            return View("Login.cshtml");
        }

        public ActionResult Login()
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                //HttpContext.GetOwinContext().Authentication.Challenge(
                //    OktaDefaults.MvcAuthenticationType);
                //return new HttpUnauthorizedResult();
                // return RedirectToAction("Index", "Account");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Logout()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                HttpContext.GetOwinContext().Authentication.SignOut(
                    CookieAuthenticationDefaults.AuthenticationType,
                    OktaDefaults.MvcAuthenticationType);
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult PostLogout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}