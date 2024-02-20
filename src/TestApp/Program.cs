// See https://aka.ms/new-console-template for more information
using CreativeMinds.CompaniesHouseData.RestApi.AppSettings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Moq;
using System.Runtime.CompilerServices;

namespace TestApp {

	public class Program {

		static void Main(String[] args) {
			var builder = new ConfigurationBuilder()
					  .SetBasePath(Directory.GetCurrentDirectory())
					  .AddJsonFile("appsettings.json", optional: false)
					  .AddJsonFile($"appsettings.{Environment.UserName}.json", optional: true);

			IConfiguration config = builder.Build();
			CancellationToken cancellationToken = new CancellationToken();

			Mock<IHttpClientFactory> http = new Mock<IHttpClientFactory>();
			http.Setup(k => k.CreateClient(It.IsAny<String>())).Returns(new HttpClient());

			CreativeMinds.CompaniesHouseData.RestApi.CompaniesHouseSearchEngine search = new CreativeMinds.CompaniesHouseData.RestApi.CompaniesHouseSearchEngine(new uksettings { ApiKey = config["CompaniesHouseSearch:ApiKey"], BaseEndpoint = config["CompaniesHouseSearch:BaseEndpoint"] }, http.Object);


			//var data = search.SearchForCompanyByNameAsync("News Group Newspapers Limited", 1, cancellationToken).Result;

			//data = search.SearchForCompanyByNameAsync("JW Brands Limited", 1, cancellationToken).Result;

			var data = search.SearchForCompanyByIdAsync("124120", 4, cancellationToken).Result;

			String temp = "";


		}
	}


	internal class uksettings : ICompaniesHouseSettings {
		public String ApiKey { get; set; }
		public String BaseEndpoint { get; set; }
	}
}