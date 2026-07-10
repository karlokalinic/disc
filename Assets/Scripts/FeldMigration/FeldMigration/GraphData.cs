using System.Collections.Generic;
using Newtonsoft.Json;
using PixelCrushers.DialogueSystem;

namespace FeldMigration
{
	public class GraphData
	{
		[JsonProperty]
		public List<GraphData> modifier;

		[JsonProperty]
		public List<GraphData> alternative;

		[JsonProperty]
		public List<GraphData> subtask;

		public List<Field> fields;

		public bool HasField(string fieldName)
		{
			return false;
		}

		public int GetNumber(string fieldName)
		{
			return 0;
		}

		public bool GetBool(string fieldName)
		{
			return false;
		}

		public string GetString(string fieldName)
		{
			return null;
		}

		public void SetField(string fieldName, int? value)
		{
		}

		public void SetField(string fieldName, bool? value)
		{
		}

		public void SetField(string fieldName, string value)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
