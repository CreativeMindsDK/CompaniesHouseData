using CreativeMinds.CompaniesHouseData.RestApi.AppSettings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CreativeMinds.CompaniesHouseData.RestApi {

	public static class ServiceCollectionExtensions {

		public static IServiceCollection AddCompaniesHouseSearch(this IServiceCollection services, IConfiguration configuration) {
			services.Configure<CompaniesHouseSettingsReader>(configuration.GetSection("CompaniesHouseSearch"));
			services.AddTransient<ICompaniesHouseSettings, CompaniesHouseSettingsBridge>();

			services.AddSingleton<ICompaniesHouseSearchEngine, CompaniesHouseSearchEngine>();

			return services;
		}
	}
}
