using System;
using Newtonsoft.Json;
using PixelCrushers.DialogueSystem;

namespace FeldMigration
{
	public class GraphDataConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return false;
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		private static FieldType GetFieldType(string variableName, JsonToken tokenType)
		{
			return default(FieldType);
		}
	}
}
