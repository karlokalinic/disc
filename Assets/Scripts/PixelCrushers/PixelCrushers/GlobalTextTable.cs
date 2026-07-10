using UnityEngine;

namespace PixelCrushers
{
	public class GlobalTextTable : MonoBehaviour
	{
		[SerializeField]
		private TextTable m_textTable;

		protected static GlobalTextTable s_instance;

		public static GlobalTextTable instance => null;

		public static TextTable textTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string currentLanguage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public static string Lookup(StringField fieldName)
		{
			return null;
		}

		public static string Lookup(string fieldName)
		{
			return null;
		}
	}
}
