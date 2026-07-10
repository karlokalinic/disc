using System.Collections.Generic;
using PixelCrushers.DialogueSystem;

namespace statistics
{
	public abstract class FieldHolder
	{
		public Dictionary<string, string> Fields;

		public static Dictionary<string, Dictionary<string, List<string>>> fieldNames;

		public abstract List<string> GetSelectableFields();

		public void ConvertFields(List<Field> fields)
		{
		}

		private static string GetFieldValue(Field ddField)
		{
			return null;
		}

		private void AddToList(string fieldName, string fieldValue)
		{
		}
	}
}
