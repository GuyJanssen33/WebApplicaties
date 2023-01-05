using FilmDatabase.Areas.Identity.Data;
using FilmDatabase.Data;
using FilmDatabase.Data.Repository;
using FilmDatabase.Data.UnitOfWork;
using FilmDatabase.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDatabase
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
			services.AddDbContext<FilmdatabaseDbContext>(options =>
			
				options.UseSqlServer(Configuration.GetConnectionString("FilmdatabaseConnection")));
			services.AddDefaultIdentity<CustomUser>()
					.AddRoles<IdentityRole>()
					.AddEntityFrameworkStores<FilmdatabaseDbContext>();
			services.AddControllersWithViews();
			services.AddRazorPages();
			services.AddScoped<IGenericRepository<Film>, GenericRepository<Film>>();			
			services.AddScoped<IGenericRepository<Regisseur>, GenericRepository<Regisseur>>();
			services.AddScoped<IGenericRepository<Acteur>, GenericRepository<Acteur>>();
			services.AddScoped<IGenericRepository<FilmActeur>, GenericRepository<FilmActeur>>();			
			services.AddScoped<IGenericRepository<FilmRegisseur>, GenericRepository<FilmRegisseur>>();
			services.AddScoped<IGenericRepository<FilmProducent>, GenericRepository<FilmProducent>>();
			services.AddScoped<IGenericRepository<Producent>, GenericRepository<Producent>>();
			services.AddScoped<IGenericRepository<Favoriet>, GenericRepository<Favoriet>>();
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.Configure<IdentityOptions>(options =>
			{
				options.Password.RequireDigit = true;
				options.Password.RequireLowercase = true;
				options.Password.RequireNonAlphanumeric = false;
				options.Password.RequireUppercase = true;
				options.Password.RequiredLength = 1;
				options.Password.RequiredUniqueChars = 1;


				options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
				options.Lockout.MaxFailedAccessAttempts = 3;
				options.Lockout.AllowedForNewUsers = true;

				options.User.AllowedUserNameCharacters =
				"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
				options.User.RequireUniqueEmail = true;
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
				endpoints.MapRazorPages();
			});

			CreateRoles(serviceProvider).Wait();
		}

		private async Task CreateRoles (IServiceProvider serviceProvider)
		{
			RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
			FilmdatabaseDbContext context = serviceProvider.GetRequiredService<FilmdatabaseDbContext>();

			IdentityResult result;

			bool rolecheck = await roleManager.RoleExistsAsync("user");
			if (!rolecheck)
			{
				result = await roleManager.CreateAsync(new IdentityRole("user"));
			}

			rolecheck = await roleManager.RoleExistsAsync("admin");
			if (!rolecheck)
			{
				result = await roleManager.CreateAsync(new IdentityRole("admin"));
			}

			context.SaveChanges();

		}
	}
}
