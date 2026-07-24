using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RaportController (IRaportRepository raportRepository)
		: ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var result = await raportRepository.GetAll();
			return Ok(result);
		}
	}
}
