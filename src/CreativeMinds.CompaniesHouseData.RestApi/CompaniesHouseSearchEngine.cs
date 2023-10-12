using CreativeMinds.CompaniesHouseData.RestApi.Dtos;
using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http.Json;
using CreativeMinds.CompaniesHouseData.RestApi.AppSettings;

namespace CreativeMinds.CompaniesHouseData.RestApi {

	public class CompaniesHouseSearchEngine : ICompaniesHouseSearchEngine {
		protected readonly String endpoint;
		protected readonly String apiKey;

		//public CompaniesHouseSearchEngine(IConfigurationSection settings) {
		//	this.endpoint = settings["BaseEndpoint"];
		//	this.apiKey = settings["ApiKey"];
		//}

		public CompaniesHouseSearchEngine(ICompaniesHouseSettings settings) {
			this.endpoint = settings.BaseEndpoint;
			this.apiKey = settings.ApiKey;
		}

		public async Task<SearchResponse> SearchForCompanyByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken) {
			HttpClient client = new HttpClient();
			client.Timeout = new TimeSpan(0, 0, 0, 0, 5000);
			client.BaseAddress = new Uri(this.endpoint);
			client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));


			var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes($"{this.apiKey}:"));

			try {
				HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"/search/companies?q={HttpUtility.UrlEncode(query)}");
				//request.Headers.Add("apikey", this.apiKey);
				request.Headers.Authorization = new AuthenticationHeaderValue("Basic", $"{base64EncodedAuthenticationString}");
				//request.Headers.Add("Authorization", $"Basic {base64EncodedAuthenticationString}");
				//request.Content = new StringContent(searchBody, Encoding.UTF8, "application/json");

				HttpResponseMessage response = await client.SendAsync(request);

				String u = await response.Content.ReadAsStringAsync();


				return await response.Content.ReadFromJsonAsync<SearchResponse>();

				//return new List<Object> {  };

				//return JsonConvert.DeserializeObject(output);

				// TODO: Handle 404, as "no results found".
			}
			catch (Exception ex) {
				throw ex;
			}
		}
	}
}