using System.Collections;
using UnityEngine;

namespace PixelCrushers
{
	public class UILocalizationManager : MonoBehaviour
	{
		[SerializeField]
		private string m_currentLanguagePlayerPrefsKey;

		[SerializeField]
		private TextTable m_textTable;

		private string m_currentLanguage;

		private static UILocalizationManager m_instance;

		public static UILocalizationManager instance
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

		public string currentLanguage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string currentLanguagePlayerPrefsKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		public void UpdateUIs(string language)
		{
		}
	}
}
