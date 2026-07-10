using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers
{
	[Serializable]
	public class UIInputField
	{
		[SerializeField]
		private InputField m_uiInputField;

		[SerializeField]
		private TMP_InputField m_textMeshProInputField;

		public InputField uiInputField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TMP_InputField textMeshProInputField
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

		public int characterLimit
		{
			get
			{
				return 0;
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

		public GameObject gameObject => null;

		public bool isActiveSelf => false;

		public bool activeInHierarchy => false;

		public UIInputField()
		{
		}

		public UIInputField(InputField uiInputField)
		{
		}

		public UIInputField(TMP_InputField textMeshProInputField)
		{
		}

		public void SetActive(bool value)
		{
		}

		public void ActivateInputField()
		{
		}

		public static bool IsNull(UITextField uiTextField)
		{
			return false;
		}
	}
}
