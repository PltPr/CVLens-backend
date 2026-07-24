using api.Dtos.Raport;
using Dapper;
using System.Data;

namespace api.Repositories
{
	public class RaportRepository (IDbConnection dbConnection)
		: IRaportRepository
	{
		public async Task<IEnumerable<RaportDto>> GetAll()
		{
			var sql = """
				SELECT 
					COUNT(a."Id") AS appCount,
					jo."JobTitle" AS JobOfferTitle
				FROM "JobOffers" jo
				LEFT JOIN "Applications" a
					ON a."JobOfferId" = jo."Id"
				GROUP BY jo."Id", jo."JobTitle"
				ORDER BY appCount DESC;
				""";

			var result = await dbConnection.QueryAsync<RaportDto>(sql);
			return result;
		}
	}
}
