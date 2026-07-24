using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
	public static class Extensions
	{
		public static async Task <IApplicationBuilder> UseMigrationAsync(this IApplicationBuilder app)
		{
			using var scope = app.ApplicationServices.CreateScope();
			using var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDBContext>();
			using var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
			var retries = 5;
			while( retries -- >0)
			{
				try
				{
					await dbContext.Database.MigrateAsync();
					await SeedDatabaseAsync(dbContext, userManager);
					return app;
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.ToString());
					await Task.Delay(1000);
				}
				
			}
			throw new Exception("Database is not available");

		}

		private static async Task SeedDatabaseAsync(ApplicationDBContext context, UserManager<AppUser>userManager)
		{
			if(!await context.JobOffers.AnyAsync())
			{
				await context.JobOffers.AddRangeAsync(SeedData.JobOffers);
				foreach (var user in SeedData.Users)
				{
					if (await userManager.FindByEmailAsync(user.Email) != null)
						continue;
					var appUser = new AppUser
					{
						Id = user.Id,
						UserName = user.Email,
						Email = user.Email,
						Name = user.Name,
						Surname = user.Surname
					};
					await userManager.CreateAsync(appUser,user.Password);
					await userManager.AddToRoleAsync(appUser, "User");
				}
				await context.CVs.AddRangeAsync(SeedData.CVs);
				await context.SaveChangesAsync();
				await context.Applications.AddRangeAsync(SeedData.Applications);
				await context.SaveChangesAsync();
			}
		}
	}
}
