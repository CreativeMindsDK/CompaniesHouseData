using CreativeMinds.CompaniesHouseData.RestApi.Converters;
using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.CompaniesHouseData.RestApi.Dtos {

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
		[JsonConverter(typeof(UnknownDateTimeJsonConverter))]        
		[JsonPropertyName("date_of_cessation")]
		public DateTime? Cessation { get; set; }
		[JsonPropertyName("description_identifier")]
		public String[] Identifier { get; set; }
		[JsonPropertyName("matches")]
		public MatchesEntity Matches { get; set; }


		/*
		 company_status:

		
    active
    dissolved
    liquidation
    receivership
    administration
    voluntary-arrangement
    converted-closed
    insolvency-proceedings
    registered
    removed


		company_type:

		
    private-unlimited
    ltd
    plc
    old-public-company
    private-limited-guarant-nsc-limited-exemption
    limited-partnership
    private-limited-guarant-nsc
    converted-or-closed
    private-unlimited-nsc
    private-limited-shares-section-30-exemption
    assurance-company
    oversea-company
    eeig
    icvc-securities
    icvc-warrant
    icvc-umbrella
    industrial-and-provident-society
    northern-ireland
    northern-ireland-other
    royal-charter
    investment-company-with-variable-capital
    unregistered-company
    llp
    other
    european-public-limited-liability-company-se
    registered-overseas-entity



		description_identifier:

		
    incorporated-on
    registered-on
    formed-on
    dissolved-on
    converted-closed-on
    closed-on
    closed
    first-uk-establishment-opened-on
    opened-on
    voluntary-arrangement
    receivership
    insolvency-proceedings
    liquidation
    administration
    registered
    removed

		 */
	}
}
