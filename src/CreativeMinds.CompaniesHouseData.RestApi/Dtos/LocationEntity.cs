using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.CompaniesHouseData.RestApi.Dtos {

	public class LocationEntity {
		[JsonPropertyName("postal_code")]
		public String PostalCode { get; set; }
		[JsonPropertyName("country")]
		public String Country { get; set; }
		[JsonPropertyName("address_line_1")]
		public String Address { get; set; }
		[JsonPropertyName("region")]
		public String Region { get; set; }
		[JsonPropertyName("premises")]
		public String Premises { get; set; }
		[JsonPropertyName("locality")]
		public String Locality { get; set; }
	}
}
