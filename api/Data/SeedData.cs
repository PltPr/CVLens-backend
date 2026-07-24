using api.Models;

namespace api.Data;

public static class SeedData
{
	public static IEnumerable<SeedUser> Users => new List<SeedUser>
	{
		new("user-1", "john.smith@test.com", "Password123!", "John", "Smith"),
		new("user-2", "anna.brown@test.com", "Password123!", "Anna", "Brown"),
		new("user-3", "michael.johnson@test.com", "Password123!", "Michael", "Johnson"),
		new("user-4", "sarah.wilson@test.com", "Password123!", "Sarah", "Wilson"),
		new("user-5", "david.taylor@test.com", "Password123!", "David", "Taylor"),
		new("user-6", "emma.anderson@test.com", "Password123!", "Emma", "Anderson"),
		new("user-7", "robert.thomas@test.com", "Password123!", "Robert", "Thomas"),
		new("user-8", "olivia.jackson@test.com", "Password123!", "Olivia", "Jackson"),
		new("user-9", "daniel.white@test.com", "Password123!", "Daniel", "White"),
		new("user-10", "sophia.harris@test.com", "Password123!", "Sophia", "Harris")
	};


	public static IEnumerable<JobOffer> JobOffers => new List<JobOffer>
	{
		new()
		{
			Id = 1,
			JobTitle = "Junior .NET Developer",
			Salary = 7000,
			Description = "ASP.NET Core, C#, Entity Framework Core"
		},
		new()
		{
			Id = 2,
			JobTitle = "Mid .NET Developer",
			Salary = 12000,
			Description = "Backend development with .NET and PostgreSQL"
		},
		new()
		{
			Id = 3,
			JobTitle = "Senior Backend Developer",
			Salary = 18000,
			Description = "Designing scalable backend systems"
		},
		new()
		{
			Id = 4,
			JobTitle = "Fullstack Developer",
			Salary = 15000,
			Description = ".NET API and React applications"
		},
		new()
		{
			Id = 5,
			JobTitle = "Frontend React Developer",
			Salary = 11000,
			Description = "React, TypeScript, modern frontend"
		},
		new()
		{
			Id = 6,
			JobTitle = "DevOps Engineer",
			Salary = 16000,
			Description = "Docker, Kubernetes, CI/CD"
		},
		new()
		{
			Id = 7,
			JobTitle = "Cloud Engineer",
			Salary = 17000,
			Description = "Azure infrastructure and cloud solutions"
		},
		new()
		{
			Id = 8,
			JobTitle = "Database Developer",
			Salary = 13000,
			Description = "SQL optimization and database design"
		},
		new()
		{
			Id = 9,
			JobTitle = "Software Architect",
			Salary = 22000,
			Description = "Architecture design for enterprise systems"
		},
		new()
		{
			Id = 10,
			JobTitle = "QA Automation Engineer",
			Salary = 10000,
			Description = "Automated testing and quality assurance"
		},
		new()
		{
			Id = 11,
			JobTitle = "Mobile Developer",
			Salary = 14000,
			Description = "Mobile applications with .NET MAUI"
		},
		new()
		{
			Id = 12,
			JobTitle = "Security Engineer",
			Salary = 19000,
			Description = "Application security and penetration testing"
		},
		new()
		{
			Id = 13,
			JobTitle = "Data Engineer",
			Salary = 18000,
			Description = "Data pipelines and processing"
		},
		new()
		{
			Id = 14,
			JobTitle = "Machine Learning Engineer",
			Salary = 20000,
			Description = "ML models and AI solutions"
		},
		new()
		{
			Id = 15,
			JobTitle = "Technical Lead",
			Salary = 25000,
			Description = "Leading development teams"
		},
		new()
		{
			Id = 16,
			JobTitle = "Backend Intern",
			Salary = 4000,
			Description = "Learning backend technologies"
		},
		new()
		{
			Id = 17,
			JobTitle = "API Developer",
			Salary = 13000,
			Description = "REST API design and integration"
		},
		new()
		{
			Id = 18,
			JobTitle = "Integration Specialist",
			Salary = 14000,
			Description = "Third party integrations and APIs"
		},
		new()
		{
			Id = 19,
			JobTitle = "System Analyst",
			Salary = 12000,
			Description = "Requirements analysis and documentation"
		},
		new()
		{
			Id = 20,
			JobTitle = "Engineering Manager",
			Salary = 28000,
			Description = "Managing engineering department"
		}
	};
	public static IEnumerable<CV> CVs => new List<CV>
	{
		new()
		{
			Id = 1,
			CvFileName = "john_smith_cv.pdf",
			CvData = Array.Empty<byte>()
		},
		new()
		{
			Id = 2,
			CvFileName = "anna_brown_cv.pdf",
			CvData = Array.Empty<byte>()
		},
		new()
		{
			Id = 3,
			CvFileName = "michael_johnson_cv.pdf",
			CvData = Array.Empty<byte>()
		},
		new()
		{
			Id = 4,
			CvFileName = "sarah_wilson_cv.pdf",
			CvData = Array.Empty<byte>()
		},
		new()
		{
			Id = 5,
			CvFileName = "david_taylor_cv.pdf",
			CvData = Array.Empty<byte>()
		},
		new()
		{
			Id = 6,
			CvFileName = "emma_anderson_cv.pdf",
			CvData = Array.Empty<byte>()
		},
		new()
		{
			Id = 7,
			CvFileName = "robert_thomas_cv.pdf",
			CvData = Array.Empty<byte>()
		},
		new()
		{
			Id = 8,
			CvFileName = "olivia_jackson_cv.pdf",
			CvData = Array.Empty<byte>()
		},
		new()
		{
			Id = 9,
			CvFileName = "daniel_white_cv.pdf",
			CvData = Array.Empty<byte>()
		},
		new()
		{
			Id = 10,
			CvFileName = "sophia_harris_cv.pdf",
			CvData = Array.Empty<byte>()
		}
	};


	public static IEnumerable<Application> Applications => new List<Application>
	{
		new()
		{
			Id = Guid.Parse("10000000-0000-0000-0000-000000000001"),
			Date = DateTime.UtcNow.AddDays(-20),
			Status = "Pending",
			AppUserId = "user-1",
			JobOfferId = 1,
			CvId = 1
		},

		new()
		{
			Id = Guid.Parse("10000000-0000-0000-0000-000000000002"),
			Date = DateTime.UtcNow.AddDays(-18),
			Status = "Accepted",
			Score = 90,
			Evaluation = "Excellent backend skills",
			AppUserId = "user-1",
			JobOfferId = 3,
			CvId = 1
		},

		new()
		{
			Id = Guid.Parse("10000000-0000-0000-0000-000000000003"),
			Date = DateTime.UtcNow.AddDays(-16),
			Status = "Interview",
			Score = 80,
			Evaluation = "Good technical knowledge",
			AppUserId = "user-2",
			JobOfferId = 2,
			CvId = 2
		},

		new()
		{
			Id = Guid.Parse("10000000-0000-0000-0000-000000000004"),
			Date = DateTime.UtcNow.AddDays(-15),
			Status = "Rejected",
			Score = 45,
			Evaluation = "Not enough experience",
			AppUserId = "user-2",
			JobOfferId = 5,
			CvId = 2
		},

		new()
		{
			Id = Guid.Parse("10000000-0000-0000-0000-000000000005"),
			Date = DateTime.UtcNow.AddDays(-14),
			Status = "Pending",
			AppUserId = "user-3",
			JobOfferId = 4,
			CvId = 3
		},

		new()
		{
			Id = Guid.Parse("10000000-0000-0000-0000-000000000006"),
			Date = DateTime.UtcNow.AddDays(-13),
			Status = "Accepted",
			Score = 88,
			Evaluation = "Strong DevOps skills",
			AppUserId = "user-3",
			JobOfferId = 6,
			CvId = 3
		},

		new()
		{
			Id = Guid.Parse("10000000-0000-0000-0000-000000000007"),
			Date = DateTime.UtcNow.AddDays(-12),
			Status = "Interview",
			Score = 75,
			Evaluation = "Azure experience",
			AppUserId = "user-4",
			JobOfferId = 7,
			CvId = 4
		},

		new()
		{
			Id = Guid.Parse("10000000-0000-0000-0000-000000000008"),
			Date = DateTime.UtcNow.AddDays(-11),
			Status = "Rejected",
			Score = 50,
			Evaluation = "Weak SQL knowledge",
			AppUserId = "user-5",
			JobOfferId = 8,
			CvId = 5
		},

		new()
		{
			Id = Guid.Parse("10000000-0000-0000-0000-000000000009"),
			Date = DateTime.UtcNow.AddDays(-10),
			Status = "Accepted",
			Score = 95,
			Evaluation = "Senior candidate",
			AppUserId = "user-6",
			JobOfferId = 9,
			CvId = 6
		},

		new()
		{
			Id = Guid.Parse("10000000-0000-0000-0000-000000000010"),
			Date = DateTime.UtcNow.AddDays(-9),
			Status = "Pending",
			AppUserId = "user-7",
			JobOfferId = 10,
			CvId = 7
		},

    new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000011"),
		Date = DateTime.UtcNow.AddDays(-8),
		Status = "Interview",
		Score = 82,
		Evaluation = "Good frontend skills",
		AppUserId = "user-8",
		JobOfferId = 11,
		CvId = 8
	},

	new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000012"),
		Date = DateTime.UtcNow.AddDays(-7),
		Status = "Rejected",
		Score = 55,
		Evaluation = "Security knowledge insufficient",
		AppUserId = "user-9",
		JobOfferId = 12,
		CvId = 9
	},

	new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000013"),
		Date = DateTime.UtcNow.AddDays(-6),
		Status = "Accepted",
		Score = 91,
		Evaluation = "Excellent candidate",
		AppUserId = "user-10",
		JobOfferId = 13,
		CvId = 10
	},

	new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000014"),
		Date = DateTime.UtcNow.AddDays(-5),
		Status = "Pending",
		AppUserId = "user-1",
		JobOfferId = 14,
		CvId = 1
	},

	new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000015"),
		Date = DateTime.UtcNow.AddDays(-5),
		Status = "Interview",
		Score = 79,
		Evaluation = "Good communication",
		AppUserId = "user-2",
		JobOfferId = 15,
		CvId = 2
	},

	new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000016"),
		Date = DateTime.UtcNow.AddDays(-4),
		Status = "Rejected",
		Score = 40,
		Evaluation = "Junior level",
		AppUserId = "user-3",
		JobOfferId = 16,
		CvId = 3
	},

	new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000017"),
		Date = DateTime.UtcNow.AddDays(-4),
		Status = "Accepted",
		Score = 87,
		Evaluation = "Great API experience",
		AppUserId = "user-4",
		JobOfferId = 17,
		CvId = 4
	},

	new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000018"),
		Date = DateTime.UtcNow.AddDays(-3),
		Status = "Pending",
		AppUserId = "user-5",
		JobOfferId = 18,
		CvId = 5
	},

	new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000019"),
		Date = DateTime.UtcNow.AddDays(-2),
		Status = "Interview",
		Score = 77,
		Evaluation = "Needs final interview",
		AppUserId = "user-6",
		JobOfferId = 19,
		CvId = 6
	},

	new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000020"),
		Date = DateTime.UtcNow.AddDays(-1),
		Status = "Accepted",
		Score = 93,
		Evaluation = "Excellent leadership",
		AppUserId = "user-7",
		JobOfferId = 20,
		CvId = 7
	},

	new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000021"),
		Date = DateTime.UtcNow.AddDays(-12),
		Status = "Pending",
		AppUserId = "user-8",
		JobOfferId = 2,
		CvId = 8
	},

	new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000022"),
		Date = DateTime.UtcNow.AddDays(-10),
		Status = "Accepted",
		Score = 89,
		Evaluation = "Strong candidate",
		AppUserId = "user-9",
		JobOfferId = 4,
		CvId = 9
	},

	new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000023"),
		Date = DateTime.UtcNow.AddDays(-9),
		Status = "Interview",
		Score = 84,
		Evaluation = "Good experience",
		AppUserId = "user-10",
		JobOfferId = 6,
		CvId = 10
	},

	new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000024"),
		Date = DateTime.UtcNow.AddDays(-7),
		Status = "Rejected",
		Score = 60,
		Evaluation = "Requirements mismatch",
		AppUserId = "user-1",
		JobOfferId = 8,
		CvId = 1
	},

	new()
	{
		Id = Guid.Parse("10000000-0000-0000-0000-000000000025"),
		Date = DateTime.UtcNow.AddDays(-6),
		Status = "Accepted",
		Score = 96,
		Evaluation = "Outstanding candidate",
		AppUserId = "user-5",
		JobOfferId = 9,
		CvId = 5
	}
};


	public record SeedUser(
		string Id,
		string Email,
		string Password,
		string Name,
		string Surname
	);
};