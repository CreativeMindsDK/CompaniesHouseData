using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.ComapniesHouseData.RestApi.Dtos {

	public class SearchResponse {
		[JsonPropertyName("etag")]
		public String Etag { get; set; }
		[JsonPropertyName("items")]
		public CompanyEntity[] Results { get; set; }
		[JsonPropertyName("items_per_page")]
		public Int32 PerPage { get; set; }
		[JsonPropertyName("start_index")]
		public Int32 StartIndex { get; set; }
		[JsonPropertyName("total_results")]
		public Int32 TotalCount { get; set; }
		[JsonPropertyName("kind")]
		public String Kind { get; set; }
	}
}
