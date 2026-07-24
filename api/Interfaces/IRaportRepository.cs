using api.Dtos.Raport;

namespace api.Interfaces
{
	public interface IRaportRepository
	{
		Task<IEnumerable<RaportDto>> GetAll();
	}
}
