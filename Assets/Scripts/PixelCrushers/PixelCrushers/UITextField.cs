using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers
{
	[Serializable]
	public class UITextField
	{
		[SerializeField]
		private Text m_uiText;

		[SerializeField]
		private TextMeshProUGUI m_textMeshProUGUI;

		public Text uiText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextMeshProUGUI textMeshProUGUI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public GameObject gameObject => null;

		public bool isActiveSelf => false;

		public bool activeInHierarchy => false;

		public UITextField()
		{
		}

		public UITextField(Text uiText)
		{
		}

		public UITextField(TextMeshProUGUI textMeshProUGUI)
		{
		}

		public void SetActive(bool value)
		{
		}

		public static bool IsNull(UITextField uiTextField)
		{
			return false;
		}
	}
}
