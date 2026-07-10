using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class StandardUISubtitleControls : AbstractUISubtitleControls
	{
		private List<StandardUISubtitlePanel> m_builtinPanels;

		private List<StandardUISubtitlePanel> m_customPanels;

		private StandardUISubtitlePanel m_defaultNPCPanel;

		private StandardUISubtitlePanel m_defaultPCPanel;

		private StandardUISubtitlePanel m_focusedPanel;

		private Dictionary<Transform, StandardUISubtitlePanel> m_actorPanelCache;

		private Dictionary<int, StandardUISubtitlePanel> m_actorIdOverridePanel;

		private Dictionary<int, StandardUISubtitlePanel> m_lastPanelUsedByActor;

		private Dictionary<StandardUISubtitlePanel, int> m_lastActorToUsePanel;

		private Dictionary<Transform, DialogueActor> m_dialogueActorCache;

		private List<Transform> m_useBarkUIs;

		private List<string> m_queuedActorGOs;

		private List<SubtitlePanelNumber> m_queuedActorGOPanels;

		private List<int> m_queuedActorIDs;

		private List<SubtitlePanelNumber> m_queuedActorIDPanels;

		public override bool hasText => false;

		public void Initialize(StandardUISubtitlePanel[] subtitlePanels, StandardUISubtitlePanel defaultNPCSubtitlePanel, StandardUISubtitlePanel defaultPCSubtitlePanel)
		{
		}

		private void ClearCache()
		{
		}

		public void OverrideActorPanel(Actor actor, SubtitlePanelNumber subtitlePanelNumber)
		{
		}

		private StandardUISubtitlePanel GetPanel(Subtitle subtitle, out DialogueActor dialogueActor)
		{
			dialogueActor = null;
			return null;
		}

		private StandardUISubtitlePanel GetActorTransformPanel(Transform speakerTransform, StandardUISubtitlePanel defaultPanel, out DialogueActor dialogueActor)
		{
			dialogueActor = null;
			return null;
		}

		private bool DialogueActorUsesBarkUI(DialogueActor dialogueActor)
		{
			return false;
		}

		private StandardUISubtitlePanel GetDialogueActorPanel(DialogueActor dialogueActor)
		{
			return null;
		}

		private StandardUISubtitlePanel GetPanelFromNumber(SubtitlePanelNumber subtitlePanelNumber, StandardUISubtitlePanel customPanel)
		{
			return null;
		}

		private bool SubtitleUsesBarkUI(Subtitle subtitle)
		{
			return false;
		}

		private string GetSubtitleTextSummary(Subtitle subtitle)
		{
			return null;
		}

		public virtual void SetActorSubtitlePanelNumber(DialogueActor dialogueActor, SubtitlePanelNumber subtitlePanelNumber)
		{
		}

		public virtual void RecordActorPanelCache(out List<string> actorGOs, out List<SubtitlePanelNumber> actorGOPanels, out List<int> actorIDs, out List<SubtitlePanelNumber> actorIDPanels)
		{
			actorGOs = null;
			actorGOPanels = null;
			actorIDs = null;
			actorIDPanels = null;
		}

		public virtual void QueueSavedActorPanelCache(List<string> actorGOs, List<SubtitlePanelNumber> actorGOPanels, List<int> actorIDs, List<SubtitlePanelNumber> actorIDPanels)
		{
		}

		public virtual void ApplyQueuedActorPanelCache()
		{
		}

		protected virtual SubtitlePanelNumber GetSubtitlePanelNumberFromPanel(StandardUISubtitlePanel panel)
		{
			return default(SubtitlePanelNumber);
		}

		public override void ShowSubtitle(Subtitle subtitle)
		{
		}

		public void HideSubtitle(Subtitle subtitle)
		{
		}

		public void Close()
		{
		}

		protected virtual void SupercedeOtherPanels(StandardUISubtitlePanel newPanel)
		{
		}

		protected virtual void SupercedeOtherPanelsInList(List<StandardUISubtitlePanel> list, StandardUISubtitlePanel newPanel)
		{
		}

		public virtual void UnfocusAll()
		{
		}

		public override void ShowContinueButton()
		{
		}

		public override void HideContinueButton()
		{
		}

		public override void SetActive(bool value)
		{
		}

		public override void SetSubtitle(Subtitle subtitle)
		{
		}

		public override void ClearSubtitle()
		{
		}

		public override void SetActorPortraitSprite(string actorName, Sprite portraitSprite)
		{
		}

		public void OpenSubtitlePanelsOnStartConversation()
		{
		}

		private void CheckActorIDOnStartConversation(int actorID, HashSet<int> checkedActorIDs, HashSet<StandardUISubtitlePanel> checkedPanels)
		{
		}

		protected Transform GetActorTransform(string actorName)
		{
			return null;
		}

		public void OpenSubtitlePanelLikeStart(SubtitlePanelNumber subtitlePanelNumber)
		{
		}

		public virtual float GetTypewriterSpeed()
		{
			return 0f;
		}

		public virtual void SetTypewriterSpeed(float charactersPerSecond)
		{
		}

		private AbstractTypewriterEffect GetTypewriter(StandardUISubtitlePanel panel)
		{
			return null;
		}
	}
}
