using System;
using UnityEngine;

namespace PixelCrushers
{
	[Serializable]
	public class StringField
	{
		[SerializeField]
		private string m_text;

		[SerializeField]
		private StringAsset m_stringAsset;

		[SerializeField]
		private TextTable m_textTable;

		[SerializeField]
		private int m_textTableFieldID;

		public static StringField empty;

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public StringAsset stringAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextTable textTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int textTableFieldID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}

		public StringField()
		{
		}

		public StringField(string text)
		{
		}

		public StringField(StringAsset stringAsset)
		{
		}

		public StringField(TextTable textTable, int fieldID)
		{
		}

		public StringField(StringField source)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool IsNullOrEmpty(StringField stringField)
		{
			return false;
		}

		public static string GetStringValue(StringField stringField)
		{
			return null;
		}
	}
}
