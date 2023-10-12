using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.CompaniesHouseData.RestApi.Dtos {

	public class LocationEntity {
		[JsonPropertyName("postal_code")]
		public String PostalCode { get; set; }
		[JsonPropertyName("country")]
		public String Country { get; set; }
		[JsonPropertyName("address_line_1")]
		public String Address1 { get; set; }
		[JsonPropertyName("address_line_2")]
		public String Address2 { get; set; }
		[JsonPropertyName("region")]
		public String Region { get; set; }
		[JsonPropertyName("premises")]
		public String Premises { get; set; }
		[JsonPropertyName("locality")]
		public String Locality { get; set; }
		[JsonPropertyName("care_of")]
		public String CareOf { get; set; }
		[JsonPropertyName("po_box")]
		public String POBox { get; set; }

		/*
		 country:

			Wales
			England
			Scotland
			Great Britain
			Not specified
			United Kingdom
			Northern Ireland

		 */

	}
}
