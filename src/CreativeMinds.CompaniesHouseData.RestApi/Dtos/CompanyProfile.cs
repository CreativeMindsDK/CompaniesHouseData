using CreativeMinds.CompaniesHouseData.RestApi.Converters;
using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.CompaniesHouseData.RestApi.Dtos {

	public class CompanyProfile {
		[JsonPropertyName("etag")]
		public String Etag { get; set; }
		[JsonPropertyName("can_file")]
		public Boolean CanFile { get; set; }
		[JsonPropertyName("company_name")]
		public String Name { get; set; }
		[JsonPropertyName("company_number")]
		public String Number { get; set; }
		[JsonPropertyName("company_status")]
		public String Statis { get; set; }
		[JsonPropertyName("company_status_detail")]
		public String StatusDetail { get; set; }
		[JsonPropertyName("date_of_creation")]
		public DateTime? Creation { get; set; }
		[JsonConverter(typeof(UnknownDateTimeJsonConverter))]
		[JsonPropertyName("date_of_cessation")]
		public DateTime? Cessation { get; set; }
		/*
		 
TODO  


https://developer-specs.company-information.service.gov.uk/companies-house-public-data-api/resources/companyprofile?v=latest

		 
		 */

	}
}
