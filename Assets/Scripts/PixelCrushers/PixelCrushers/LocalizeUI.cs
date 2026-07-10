using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers
{
	public class LocalizeUI : MonoBehaviour
	{
		[SerializeField]
		private TextTable m_textTable;

		[SerializeField]
		private string m_fieldName;

		private bool m_started;

		private List<string> m_fieldNames;

		private Text m_text;

		private Dropdown m_dropdown;

		private TextMeshProUGUI m_textMeshProUGUI;

		private bool m_lookedForTMP;

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

		protected bool started
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		protected List<string> fieldNames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Text text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dropdown dropdown
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

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		public virtual void UpdateText()
		{
		}

		protected virtual string GetLocalizedText(string fieldName)
		{
			return null;
		}

		public virtual void SetFieldName(string newFieldName = "")
		{
		}

		public virtual void UpdateDropdownOptions()
		{
		}
	}
}
