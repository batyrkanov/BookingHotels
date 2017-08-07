﻿using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using BookingHotels.BLL.Services;
using Microsoft.AspNet.Identity;
using BookingHotels.BLL.Interfaces;
 
[assembly: OwinStartup(typeof(BookingHotels.App_Start.Startup))]
 
namespace BookingHotels.App_Start
{
    public class Startup
    {
        IServiceCreator serviceCreator = new ServiceCreator();
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<IUserService>(CreateUserService);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }

        private IUserService CreateUserService()
        {
            return serviceCreator.CreateUserService("DefaultConnection");
        }
    }
}