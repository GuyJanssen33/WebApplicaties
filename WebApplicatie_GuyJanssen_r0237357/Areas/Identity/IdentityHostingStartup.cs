using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplicatie_GuyJanssen_r0237357.Data;

[assembly: HostingStartup(typeof(WebApplicatie_GuyJanssen_r0237357.Areas.Identity.IdentityHostingStartup))]
namespace WebApplicatie_GuyJanssen_r0237357.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}