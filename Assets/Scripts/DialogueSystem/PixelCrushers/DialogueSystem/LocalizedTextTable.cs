using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class LocalizedTextTable : ScriptableObject
	{
		[Serializable]
		public class LocalizedTextField
		{
			public string name;

			public List<string> values;
		}

		public List<string> languages;

		public List<LocalizedTextField> fields;

		private const int LanguageNotFound = -1;

		public string Item => null;

		public bool ContainsField(string fieldName)
		{
			return false;
		}

		private string GetText(string fieldName)
		{
			return null;
		}

		private string GetTextInLanguage(string fieldName, int languageIndex)
		{
			return null;
		}

		private int GetLanguageIndex()
		{
			return 0;
		}
	}
}
