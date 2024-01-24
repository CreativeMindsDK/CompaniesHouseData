using System;

namespace CreativeMinds.CompaniesHouseData.RestApi.AppSettings {

	public class CompaniesHouseSettingsReader : ICompaniesHouseSettings {
		public String ApiKey { get; set; }
		public String BaseEndpoint { get; set; }
	}
}
