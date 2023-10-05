using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.ComapniesHouseData.RestApi.Dtos {

	public class CompanyEntity {
		[JsonPropertyName("company_number")]
		public String Id { get; set; }
		[JsonPropertyName("title")]
		public String Name { get; set; }
		[JsonPropertyName("snippet")]
		public String Snippet { get; set; }
		[JsonPropertyName("kind")]
		public String Kind { get; set; }
		[JsonPropertyName("company_status")]
		public String Status { get; set; }
		[JsonPropertyName("address")]
		public LocationEntity Address { get; set; }
		[JsonPropertyName("address_snippet")]
		public String AddressSnippet { get; set; }
		[JsonPropertyName("description")]
		public String Description { get; set; }
		[JsonPropertyName("company_type")]
		public String Type { get; set; }
		[JsonPropertyName("date_of_creation")]
		public DateTime? Creation { get; set; }
		[JsonPropertyName("date_of_cessation")]
		public DateTime? Cessation { get; set; }
		[JsonPropertyName("description_identifier")]
		public String[] Identifier { get; set; }
	}
}
