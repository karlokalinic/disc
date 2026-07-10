using System;
using Newtonsoft.Json;

namespace FeldMigration
{
	public class FeldCardConverter : JsonConverter
	{
		public override bool CanWrite => false;

		public override bool CanConvert(Type objectType)
		{
			return false;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		private void AddDefaultDefinitions(FeldCard card)
		{
		}

		private void AddDefaultOutputsDefinitions(FeldCard card)
		{
		}

		private void AddDefaultInputsDefinitions(FeldCard card)
		{
		}
	}
}
