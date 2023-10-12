using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CreativeMinds.CompaniesHouseData.RestApi.Converters {

	public class UnknownDateTimeJsonConverter : JsonConverter<DateTime?> {

		public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
			String value = reader.GetString();
			if (String.IsNullOrWhiteSpace(value) == false && value != "Unknown") {
				return DateTime.ParseExact(value,"yyyy-MM-dd", CultureInfo.InvariantCulture);
			}
			return null;
		}

		public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options) {
			throw new NotImplementedException();
		}
	}
}
