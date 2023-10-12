using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.CompaniesHouseData.RestApi.Dtos {

	public class MatchesEntity {
		[JsonPropertyName("address_snippet")]
		public Int32[] AddressSnippet { get; set; }
		[JsonPropertyName("title")]
		public Int32[] Title { get; set; }
		[JsonPropertyName("snippet")]
		public Int32[] Snippet { get; set; }
	}
}
