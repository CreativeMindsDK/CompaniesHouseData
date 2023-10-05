using System;

namespace CreativeMinds.ComapniesHouseData.RestApi.AppSettings {

	public interface ICompaniesHouseSettings {
		String ApiKey { get; }
		String BaseEndpoint { get; }
	}
}
