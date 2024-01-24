using Microsoft.Extensions.Options;
using System;

namespace CreativeMinds.CompaniesHouseData.RestApi.AppSettings {

	public class CompaniesHouseSettingsBridge : ICompaniesHouseSettings {
		protected readonly IOptionsMonitor<CompaniesHouseSettingsReader> optionsConfig;

		public CompaniesHouseSettingsBridge(IOptionsMonitor<CompaniesHouseSettingsReader> optionsConfig) {
			this.optionsConfig = optionsConfig ?? throw new ArgumentNullException(nameof(optionsConfig));
		}

		public String ApiKey => this.optionsConfig.CurrentValue.ApiKey;

		public String BaseEndpoint => this.optionsConfig.CurrentValue.BaseEndpoint;
	}
}
