using CreativeMinds.CompaniesHouseData.RestApi.Dtos;
using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http.Json;
using CreativeMinds.CompaniesHouseData.RestApi.AppSettings;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace CreativeMinds.CompaniesHouseData.RestApi {

	public class CompaniesHouseSearchEngine : ICompaniesHouseSearchEngine {
		protected readonly String endpoint;
		protected readonly String apiKey;
		protected readonly IHttpClientFactory httpClientFactory;

		//public CompaniesHouseSearchEngine(IConfigurationSection settings) {
		//	this.endpoint = settings["BaseEndpoint"];
		//	this.apiKey = settings["ApiKey"];
		//}

		public CompaniesHouseSearchEngine(ICompaniesHouseSettings settings, IHttpClientFactory httpClientFactory) {
			this.endpoint = settings.BaseEndpoint;
			this.apiKey = settings.ApiKey;
			this.httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
		}

		public async Task<CompanyProfile> SearchForCompanyByIdAsync(String companyId, Int32 maxHits, CancellationToken cancellationToken) {
			var activity = Activity.Current?.AddEvent(new ActivityEvent("Companies House, searching for company by id", tags: new ActivityTagsCollection(new List<KeyValuePair<String, Object?>> { new KeyValuePair<String, Object?>("companyId", companyId) })));

			using HttpClient client = this.httpClientFactory.CreateClient();

			client.Timeout = new TimeSpan(0, 0, 0, 0, 5000);
			client.BaseAddress = new Uri(this.endpoint);
			client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

			var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes($"{this.apiKey}:"));

			try {
				HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"/search/company/{HttpUtility.UrlEncode(companyId)}");
				//request.Headers.Add("apikey", this.apiKey);
				request.Headers.Authorization = new AuthenticationHeaderValue("Basic", $"{base64EncodedAuthenticationString}");
				//request.Headers.Add("Authorization", $"Basic {base64EncodedAuthenticationString}");
				//request.Content = new StringContent(searchBody, Encoding.UTF8, "application/json");

				HttpResponseMessage response = await client.SendAsync(request);

				String u = await response.Content.ReadAsStringAsync();

				return await response.Content.ReadFromJsonAsync<CompanyProfile>();

				//return new List<Object> {  };

				//return JsonConvert.DeserializeObject(output);

				// TODO: Handle 404, as "no results found".
			}
			catch (Exception ex) {
				throw ex;
			}
		}

		public async Task<SearchResponse> SearchForCompanyByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken) {
			var activity = Activity.Current?.AddEvent(new ActivityEvent("Companies House, searching for company by name", tags: new ActivityTagsCollection(new List<KeyValuePair<String, Object?>> { new KeyValuePair<String, Object?>("name", query) })));

			using HttpClient client = this.httpClientFactory.CreateClient();

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