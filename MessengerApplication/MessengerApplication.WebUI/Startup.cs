﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MessengerApplication.WebUI.Startup))]
namespace MessengerApplication.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}