using System;

namespace CreativeMinds.CompaniesHouseData.RestApi.AppSettings {

	public interface ICompaniesHouseSettings {
		String ApiKey { get; }
		String BaseEndpoint { get; }
	}
}
