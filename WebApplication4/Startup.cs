﻿using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Okta.AspNet;
using System.Collections.Generic;
using System.Configuration;


[assembly: OwinStartup(typeof(WebApplication4.Startup1))]

namespace WebApplication4
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);

            app.UseCookieAuthentication(new CookieAuthenticationOptions());

            //app.UseOktaMvc(new OktaMvcOptions()
            //{
            //    OktaDomain = ConfigurationManager.AppSettings["okta:OktaDomain"],
            //    ClientId = ConfigurationManager.AppSettings["okta:ClientId"],
            //    ClientSecret = ConfigurationManager.AppSettings["okta:ClientSecret"],
            //    RedirectUri = ConfigurationManager.AppSettings["okta:RedirectUri"],
            //    PostLogoutRedirectUri = ConfigurationManager.AppSettings["okta:PostLogoutRedirectUri"],
            //    GetClaimsFromUserInfoEndpoint = true,
            //    Scope = new List<string> { "openid", "profile", "email" },
            //});
        }
    }
}
