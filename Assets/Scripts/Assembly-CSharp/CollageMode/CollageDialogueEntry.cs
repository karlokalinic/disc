using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class CollageDialogueEntry : MonoBehaviour
	{
		[SerializeField]
		private GameObject selection;

		protected TMP_InputField inputField;

		protected CanvasGroup canvasGroup;

		protected LayoutElement layoutElement;

		protected TextMeshProUGUI placeholderText;

		private bool isBeingEdited;

		private bool eglibleToRemoveByBackspace;

		private bool isSelected;

		private bool isAutofillPreview;

		private string autofillPreviousText;

		public string PreviousText { get; private set; }

		public int Index { get; set; }

		public bool IsSelected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action<CollageDialogueEntry> OnValueChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<CollageDialogueEntry> OnEdit
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<CollageDialogueEntry> OnEndEdit
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<CollageDialogueEntry> OnSubmit
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<CollageDialogueEntry> OnSelect
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<CollageDialogueEntry> OnAutofill
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<CollageDialogueEntry> OnAutofillPreview
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		private void OnAfterScreenshot()
		{
		}

		private void OnBeforeScreenshot()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public void Edit()
		{
		}

		public void EndEdit()
		{
		}

		public virtual void Autofill(Operation operation)
		{
		}

		public virtual void AutofillPreview(Operation operation)
		{
		}

		public virtual void AutofillPreviewEnd()
		{
		}

		public virtual void OnInputFieldValueChanged(string value)
		{
		}

		protected virtual string PrepareAutofillString(Operation operation)
		{
			return null;
		}

		private void OnInputFieldEndEdit(string value)
		{
		}

		private void FilterText()
		{
		}

		private void OnInputFieldSelect(string value)
		{
		}
	}
}
