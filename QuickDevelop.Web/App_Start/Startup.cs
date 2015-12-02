using System;
using System.Configuration;
using QuickDevelop.Api.Controllers;
using QuickDevelop.Web;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.Sina;
using Microsoft.Owin.Security.Tencent;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace QuickDevelop.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseOAuthBearerAuthentication(AccountController.OAuthBearerOptions);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });

            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            //if (IsTrue("ExternalAuth.Google.IsEnabled"))
            //{
            //    app.UseGoogleAuthentication(CreateGoogleAuthOptions());
            //}
            if (IsTrue("ExternalAuth.Sina.IsEnabled"))
            {
                app.UseSinaAuthentication(CreateSinaAuthOptions());
            }
            if (IsTrue("ExternalAuth.Tencent.IsEnabled"))
            {
                app.UseTencentAuthentication(CreateTencentAuthOptions());
            }
        }

        private TencentAuthenticationOptions CreateTencentAuthOptions()
        {
            return new TencentAuthenticationOptions
            {
                AppId = ConfigurationManager.AppSettings["ExternalAuth.Tencent.AppId"],
                AppSecret = ConfigurationManager.AppSettings["ExternalAuth.Tencent.AppSecret"],
                Caption="腾讯QQ"
            };
        }

        private SinaAuthenticationOptions CreateSinaAuthOptions()
        {
            return new SinaAuthenticationOptions
            {
                AppId = ConfigurationManager.AppSettings["ExternalAuth.Sina.AppId"],
                AppSecret = ConfigurationManager.AppSettings["ExternalAuth.Sina.AppSecret"],
                Caption="新浪微博"
            };
        }

        //private static GoogleOAuth2AuthenticationOptions CreateGoogleAuthOptions()
        //{
        //    return new GoogleOAuth2AuthenticationOptions
        //    {
        //        ClientId = ConfigurationManager.AppSettings["ExternalAuth.Google.ClientId"],
        //        ClientSecret = ConfigurationManager.AppSettings["ExternalAuth.Google.ClientSecret"]
        //    };
        //}

        private static bool IsTrue(string appSettingName)
        {
            return string.Equals(
                ConfigurationManager.AppSettings[appSettingName],
                "true",
                StringComparison.InvariantCultureIgnoreCase);
        }
    }
}