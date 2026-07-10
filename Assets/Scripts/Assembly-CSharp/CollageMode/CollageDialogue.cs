using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class CollageDialogue : MonoBehaviour, INavigationReceiver
	{
		public const string ACTOR_SEPARATOR = " -";

		[SerializeField]
		private CollageDialogueEntriesContainer dialogueEntriesContainer;

		[SerializeField]
		private CollageAnswerEntriesContainer answerEntriesContainer;

		[SerializeField]
		private CollageDialogueContinueButton continueButton;

		[SerializeField]
		private CanvasGroup portraitParent;

		[SerializeField]
		private Image portraitImage;

		[SerializeField]
		private MultipleToggle continueTypeToggle;

		[SerializeField]
		private CollageDialogueOpener dialogueOpener;

		private ContinueType continueType;

		private CollageDialogueEntry selectedEntry;

		private ListComposite<CollageDialogueEntry> allSelectableEntries;

		private CollageDialogueSerializer serializer;

		public CollageDialogueEntriesContainer DialogueEntriesContainer => null;

		public CollageAnswerEntriesContainer AnswerEntriesContainer => null;

		public CollageDialogueContinueButton ContinueButton => null;

		public CollageDialogueOpener DialogueOpener => null;

		public ContinueType ContinueType => default(ContinueType);

		public CollageDialogueSerializer Serializer => null;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Clear()
		{
		}

		public BaseCollageDialogueEntriesContainer GetContainer(CollageDialogueEntryType entryType)
		{
			return null;
		}

		public void SetContinueType(ContinueType continueType)
		{
		}

		public void SelectPrevious()
		{
		}

		public void SelectNext()
		{
		}

		private void SetSelectedEntry(CollageDialogueEntry newSelected)
		{
		}

		private void OnContinueTypeToggleValueChanged()
		{
		}

		private void OnOpenedChanged(bool isOpened)
		{
		}

		private void SetPortraitVisibility(bool isVisible)
		{
		}

		private void OnDialogueEntriesContainerChanged()
		{
		}

		private void RefreshPortrait()
		{
		}
	}
}
