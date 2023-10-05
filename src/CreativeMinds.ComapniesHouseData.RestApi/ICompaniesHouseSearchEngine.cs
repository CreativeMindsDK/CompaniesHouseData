using CreativeMinds.ComapniesHouseData.RestApi.Dtos;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreativeMinds.ComapniesHouseData.RestApi {

	public interface ICompaniesHouseSearchEngine {
		Task<SearchResponse> SearchForCompanyByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken);
	}
}
