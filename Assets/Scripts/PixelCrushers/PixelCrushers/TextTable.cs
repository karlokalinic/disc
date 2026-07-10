using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers
{
	public class TextTable : ScriptableObject, ISerializationCallbackReceiver
	{
		protected struct LanguageKeyValuePair
		{
			public string key;

			public int value;

			public LanguageKeyValuePair(string key, int value)
			{
				this.key = null;
				this.value = 0;
			}
		}

		protected struct FieldKeyValuePair
		{
			public int key;

			public TextTableField value;

			public FieldKeyValuePair(int key, TextTableField value)
			{
				this.key = 0;
				this.value = null;
			}
		}

		private static int s_currentLanguageID;

		private Dictionary<string, int> m_languages;

		private Dictionary<int, TextTableField> m_fields;

		[SerializeField]
		private List<string> m_languageKeys;

		[SerializeField]
		private List<int> m_languageValues;

		[SerializeField]
		private List<int> m_fieldKeys;

		[SerializeField]
		private List<TextTableField> m_fieldValues;

		[SerializeField]
		private int m_nextLanguageID;

		[SerializeField]
		private int m_nextFieldID;

		public static int currentLanguageID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Dictionary<string, int> languages
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dictionary<int, TextTableField> fields
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int nextLanguageID => 0;

		public int nextFieldID => 0;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public bool HasLanguage(string languageName)
		{
			return false;
		}

		public bool HasLanguage(int languageID)
		{
			return false;
		}

		public string GetLanguageName(int languageID)
		{
			return null;
		}

		public int GetLanguageID(string languageName)
		{
			return 0;
		}

		public string[] GetLanguageNames()
		{
			return null;
		}

		public int[] GetLanguageIDs()
		{
			return null;
		}

		public void AddLanguage(string languageName)
		{
		}

		public void RemoveLanguage(string languageName)
		{
		}

		public void RemoveLanguage(int languageID)
		{
		}

		public void RemoveAll()
		{
		}

		public void SortLanguages()
		{
		}

		public bool HasField(int fieldID)
		{
			return false;
		}

		public bool HasField(string fieldName)
		{
			return false;
		}

		public TextTableField GetField(int fieldID)
		{
			return null;
		}

		public TextTableField GetField(string fieldName)
		{
			return null;
		}

		public int GetFieldID(string fieldName)
		{
			return 0;
		}

		public string GetFieldName(int fieldID)
		{
			return null;
		}

		public bool HasFieldTextForLanguage(int fieldID, int languageID)
		{
			return false;
		}

		public bool HasFieldTextForLanguage(int fieldID, string languageName)
		{
			return false;
		}

		public bool HasFieldTextForLanguage(string fieldName, int languageID)
		{
			return false;
		}

		public bool HasFieldTextForLanguage(string fieldName, string languageName)
		{
			return false;
		}

		public string GetFieldTextForLanguage(int fieldID, int languageID)
		{
			return null;
		}

		public string GetFieldTextForLanguage(int fieldID, string languageName)
		{
			return null;
		}

		public string GetFieldTextForLanguage(string fieldName, int languageID)
		{
			return null;
		}

		public string GetFieldTextForLanguage(string fieldName, string languageName)
		{
			return null;
		}

		public string GetFieldText(int fieldID)
		{
			return null;
		}

		public string GetFieldText(string fieldName)
		{
			return null;
		}

		public int[] GetFieldIDs()
		{
			return null;
		}

		public string[] GetFieldNames()
		{
			return null;
		}

		public void AddField(string fieldName)
		{
		}

		public void SetFieldTextForLanguage(int fieldID, int languageID, string text)
		{
		}

		public void SetFieldTextForLanguage(string fieldName, int languageID, string text)
		{
		}

		public void SetFieldTextForLanguage(int fieldID, string languageName, string text)
		{
		}

		public void SetFieldTextForLanguage(string fieldName, string languageName, string text)
		{
		}

		public void RemoveField(int fieldID)
		{
		}

		public void RemoveField(string fieldName)
		{
		}

		private void RemoveLanguageFromFields(int languageID)
		{
		}

		public void RemoveAllFields()
		{
		}

		public void InsertField(int index, string fieldName)
		{
		}

		public void SortFields()
		{
		}

		public void ReorderFields(List<string> order)
		{
		}
	}
}
