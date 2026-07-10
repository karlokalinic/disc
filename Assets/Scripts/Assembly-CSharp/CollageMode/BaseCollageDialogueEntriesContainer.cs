using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CollageMode
{
	public abstract class BaseCollageDialogueEntriesContainer : MonoBehaviour
	{
		[SerializeField]
		protected BaseOperationsSet autofillOperationSet;

		[SerializeField]
		protected CollageDialogueEntry dialogueEntryPrefab;

		[SerializeField]
		protected CollageDialogueAutofill autofill;

		protected GenericObjectPool<CollageDialogueEntry> dialogueEntriesPool;

		protected List<CollageDialogueEntry> dialogueEntries;

		public List<CollageDialogueEntry> DialogueEntries { get; private set; }

		protected abstract CollageDialogueEntryType EntryType { get; }

		public event Action OnChanged
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

		protected virtual void Start()
		{
		}

		public void Clear()
		{
		}

		public void AddEntry(int index)
		{
		}

		public void SetEntryText(int index, string text)
		{
		}

		public void RemoveEntry(int index)
		{
		}

		protected virtual void InvokeOnChanged()
		{
		}

		private void InitPool()
		{
		}

		private void OnEndEdit(CollageDialogueEntry dialogueEntry)
		{
		}

		private void OnSubmit(CollageDialogueEntry dialogueEntry)
		{
		}

		private void RemoveEntry(CollageDialogueEntry dialogueEntry)
		{
		}

		private void OnValueChanged(CollageDialogueEntry dialogueEntry)
		{
		}

		private void OnEdit(CollageDialogueEntry dialogueEntry)
		{
		}

		private void OnSelect(CollageDialogueEntry dialogueEntry)
		{
		}

		private void OnAutofill(CollageDialogueEntry dialogueEntry)
		{
		}

		private void OnAutofillPreview(CollageDialogueEntry dialogueEntry)
		{
		}

		private string GetAutofillString(string text)
		{
			return null;
		}

		private void RefreshEntriesOrder()
		{
		}

		private void RefreshAutofill(CollageDialogueEntry dialogueEntry)
		{
		}
	}
}
