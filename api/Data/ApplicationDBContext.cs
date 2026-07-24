using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace api.Data
{
	public class ApplicationDBContext : IdentityDbContext<AppUser>
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions)
			:base(dbContextOptions)
		{
			
		}
		public DbSet<JobOffer> JobOffers { get; set; }
		public DbSet<Application> Applications { get; set; }
		public DbSet<CV> CVs { get; set; }


		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);



			List<IdentityRole> roles = new List<IdentityRole>
				{
					new IdentityRole
					{
						Id="Admin",
						Name="Admin",
						NormalizedName="ADMIN"
					},
					new IdentityRole
					{
						Id="User",
						Name="User",
						NormalizedName="USER"
					},
					new IdentityRole
					{
						Id="Examiner",
						Name="Examiner",
						NormalizedName="EXAMINER"
					}
				};
			builder.Entity<IdentityRole>().HasData(roles);
		}

	}
}
