using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CollageMode
{
	public class CollageDialogueAutofill : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, INavigationReceiver
	{
		[SerializeField]
		private CollageDialogueAutofillEntry autofillEntryPrefab;

		[SerializeField]
		private Transform entriesParent;

		[SerializeField]
		private ScrollRect scrollRect;

		[SerializeField]
		private Transform favouriteSeparator;

		[SerializeField]
		private float gamepadScrollSpeed;

		private CollageDialogueAutofillEntry selectedEntry;

		private GenericObjectPool<CollageDialogueAutofillEntry> autofillEntriesPool;

		private List<CollageDialogueAutofillEntry> currentAutofillEntries;

		private BaseOperationsSet autofillOperationsSet;

		private CollageDialogueEntry editedDialogueEntry;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void SelectNext()
		{
		}

		public void SelectPrevious()
		{
		}

		private void InitPool()
		{
		}

		public void RefreshAutofill(string characterNameBeginning)
		{
		}

		public void Show(CollageDialogueEntry collageDialogueEntry, BaseOperationsSet autofillOperationsSet)
		{
		}

		public void Hide()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		private void SelectEntry(CollageDialogueAutofillEntry entry)
		{
		}

		private void OnEntrySubmit(CollageDialogueAutofillEntry autofillEntry)
		{
		}

		private void OnEntryHovered(CollageDialogueAutofillEntry autofillEntry)
		{
		}

		private void OnEntryHoverEnded(CollageDialogueAutofillEntry autofillEntry)
		{
		}
	}
}
