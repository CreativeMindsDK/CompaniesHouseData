using CreativeMinds.CompaniesHouseData.RestApi.Dtos;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreativeMinds.CompaniesHouseData.RestApi {

	public interface ICompaniesHouseSearchEngine {
		Task<SearchResponse> SearchForCompanyByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken);
		Task<CompanyProfile> SearchForCompanyByIdAsync(String companyId, Int32 maxHits, CancellationToken cancellationToken);
	}
}
