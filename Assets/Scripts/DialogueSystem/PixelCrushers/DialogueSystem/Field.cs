using System;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem.ChatMapper;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class Field
	{
		public string title;

		public string value;

		public FieldType type;

		public string typeString;

		private static readonly List<string> filenameFields;

		public Field()
		{
		}

		public Field(PixelCrushers.DialogueSystem.ChatMapper.Field chatMapperField)
		{
		}

		public Field(string title, string value, FieldType type)
		{
		}

		public Field(string title, string value, FieldType type, string typeString)
		{
		}

		public Field(Field sourceField)
		{
		}

		public void Assign(PixelCrushers.DialogueSystem.ChatMapper.Field chatMapperField)
		{
		}

		public static FieldType StringToFieldType(string chatMapperType)
		{
			return default(FieldType);
		}

		public static List<Field> CreateListFromChatMapperFields(List<PixelCrushers.DialogueSystem.ChatMapper.Field> chatMapperFields)
		{
			return null;
		}

		public static List<Field> CopyFields(List<Field> sourceFields)
		{
			return null;
		}

		public static bool FieldExists(List<Field> fields, string title)
		{
			return false;
		}

		public static Field Lookup(List<Field> fields, string title)
		{
			return null;
		}

		public static string LookupValue(List<Field> fields, string title)
		{
			return null;
		}

		public static string LookupLocalizedValue(List<Field> fields, string title)
		{
			return null;
		}

		public static int LookupInt(List<Field> fields, string title)
		{
			return 0;
		}

		public static float LookupFloat(List<Field> fields, string title)
		{
			return 0f;
		}

		public static bool LookupBool(List<Field> fields, string title)
		{
			return false;
		}

		public static void SetValue(List<Field> fields, string title, string value, FieldType type)
		{
		}

		public static void SetValue(List<Field> fields, string title, string value)
		{
		}

		public static void SetValue(List<Field> fields, string title, float value)
		{
		}

		public static void SetValue(List<Field> fields, string title, int value)
		{
		}

		public static void SetValue(List<Field> fields, string title, bool value)
		{
		}

		public static bool IsFieldAssigned(List<Field> fields, string title)
		{
			return false;
		}

		public static Field AssignedField(List<Field> fields, string title)
		{
			return null;
		}

		public static string FieldValue(Field field)
		{
			return null;
		}

		public static string LocalizedTitle(string title)
		{
			return null;
		}

		public static string GetTypeString(FieldType type)
		{
			return null;
		}
	}
}
