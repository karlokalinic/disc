using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Sunshine.Views
{
	public class SaveGameListEntry : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, ISelectHandler, ISubmitHandler, IDeselectHandler, IPoolable
	{
		[Serializable]
		private class SaveGameListEntryState
		{
			[SerializeField]
			private Color backgroundColor;

			[SerializeField]
			private Color textColor;

			public void Apply(SaveGameListEntry entry)
			{
			}
		}

		public static bool IsEditingInputField;

		[SerializeField]
		private SaveGameListEntryState normalState;

		[SerializeField]
		private SaveGameListEntryState hoveredState;

		[SerializeField]
		private SaveGameListEntryState nonEditableState;

		[SerializeField]
		private SaveGameListEntryState selectedState;

		[SerializeField]
		private SaveGameListEntryState pressedState;

		[SerializeField]
		private Image backgroundImage;

		[SerializeField]
		private InputField saveNameInputField;

		[SerializeField]
		private Selectable loadButtonSelecteble;

		[SerializeField]
		private Text saveDateText;

		[SerializeField]
		private Text saveHourText;

		[SerializeField]
		private Text newSaveText;

		[SerializeField]
		private TMP_InputField saveNameInputFieldTMP;

		[SerializeField]
		private TMP_Text saveDateTextTMP;

		[SerializeField]
		private TMP_Text saveHourTextTMP;

		[SerializeField]
		private TMP_Text newSaveTextTMP;

		[SerializeField]
		private bool useTMPro;

		private bool isHovered;

		private bool isPressed;

		private bool isSelected;

		private static string NEW_SAVE => null;

		private static string INTERNAL_SAVE => null;

		private string SaveNameText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private string SaveHourText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private string SaveDateText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private string NewSaveText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private Selectable SaveNameAsSelectable => null;

		private Color SaveNameColor
		{
			set
			{
			}
		}

		private Color NewSaveColor
		{
			set
			{
			}
		}

		private Color SaveDateColor
		{
			set
			{
			}
		}

		private Color SaveHourColor
		{
			set
			{
			}
		}

		private bool SaveNameIsFocused => false;

		public Selectable ButtonSelectable => null;

		public bool IsNewSave { get; private set; }

		public bool IsBundled { get; private set; }

		private bool IsLoadButton { get; set; }

		public string SaveGameFileName { get; set; }

		public string SaveName { get; private set; }

		public string ShortenSaveName => null;

		public string EditedSaveName => null;

		public bool IsSaveNameEdited => false;

		private bool IsQuickSave => false;

		private bool IsEditable => false;

		public bool IsOverridable => false;

		public bool IsDeletable => false;

		public event Action<SaveGameListEntry> OnClicked
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

		public event Action OnSubmitted
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

		public event Action<string, string> OnRenamed
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

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Refresh()
		{
		}

		public void Init(string saveName, bool isBundled = false, bool isNewSave = false, bool isLoadButton = false)
		{
		}

		public void SetUpTarget(SaveGameListEntry selectable)
		{
		}

		public void SetDownTarget(SaveGameListEntry selectable)
		{
		}

		public void Rename(string newSaveName)
		{
		}

		public void SetSelected(bool selected)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		private void ActivateTextInputField()
		{
		}

		private void DeactivateTextInputField()
		{
		}

		private IEnumerator InputFieldDeactivate()
		{
			return null;
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}

		private void ShowDetails()
		{
		}

		private void OnTextValueChanged(string newText)
		{
		}

		private void OnTextValueEndEdit(string newText)
		{
		}

		private IEnumerator SubmitDelay()
		{
			return null;
		}

		public void Initialize()
		{
		}

		public void ResetState()
		{
		}
	}
}
