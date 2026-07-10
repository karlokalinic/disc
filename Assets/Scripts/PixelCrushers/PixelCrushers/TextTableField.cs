using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers
{
	[Serializable]
	public class TextTableField : ISerializationCallbackReceiver
	{
		[SerializeField]
		private string m_fieldName;

		private Dictionary<int, string> m_texts;

		[SerializeField]
		private List<int> m_keys;

		[SerializeField]
		private List<string> m_values;

		public string fieldName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dictionary<int, string> texts
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextTableField()
		{
		}

		public TextTableField(string fieldName)
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public bool HasTextForLanguage(int languageID)
		{
			return false;
		}

		public string GetTextForLanguage(int languageID)
		{
			return null;
		}

		public void SetTextForLanguage(int languageID, string text)
		{
		}

		public void RemoveLanguage(int languageID)
		{
		}
	}
}
