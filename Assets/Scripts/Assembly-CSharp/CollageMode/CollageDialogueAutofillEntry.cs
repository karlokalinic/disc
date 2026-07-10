using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CollageMode
{
	public class CollageDialogueAutofillEntry : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[SerializeField]
		private Image portraitImage;

		[SerializeField]
		private TextMeshProUGUI characterNameText;

		[SerializeField]
		private Button button;

		[SerializeField]
		private GameObject[] selection;

		private bool isSelected;

		public Operation Operation { get; private set; }

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

		public event Action<CollageDialogueAutofillEntry> OnSubmit
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

		public event Action<CollageDialogueAutofillEntry> OnHover
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

		public event Action<CollageDialogueAutofillEntry> OnHoverEnd
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

		private void Awake()
		{
		}

		public void SetCharacter(Operation operation)
		{
		}

		private void OnButtonClick()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}
	}
}
