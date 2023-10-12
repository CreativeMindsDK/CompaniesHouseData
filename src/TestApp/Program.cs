// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

namespace TestApp {

	internal class Program {

		static void Main(String[] args) {
			var builder = new ConfigurationBuilder()
					  .SetBasePath(Directory.GetCurrentDirectory())
					  .AddJsonFile("appsettings.json", optional: false)
					  .AddJsonFile($"appsettings.{Environment.UserName}.json", optional: true);

			IConfiguration config = builder.Build();
			CancellationToken cancellationToken = new CancellationToken();

			//CreativeMinds.CompaniesHouseData.RestApi.CompaniesHouseSearchEngine search = new CreativeMinds.CompaniesHouseData.RestApi.CompaniesHouseSearchEngine(config.GetSection("CompaniesHouseSearch"));

			//var data = search.SearchForCompanyByNameAsync("JW Brands Limited", 1, cancellationToken).Result;

			String temp = "";

		}
	}
}