using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class StandardUIResponseMenuControls : AbstractUIResponseMenuControls
	{
		public Action timeoutHandler;

		protected List<StandardUIMenuPanel> m_builtinPanels;

		protected StandardUIMenuPanel m_defaultPanel;

		protected Dictionary<Transform, StandardUIMenuPanel> m_actorPanelCache;

		protected StandardUIMenuPanel m_currentPanel;

		protected Sprite m_pcPortraitSprite;

		protected string m_pcPortraitName;

		protected bool useFirstResponseForPortrait;

		public override AbstractUISubtitleControls subtitleReminderControls => null;

		public void Initialize(StandardUIMenuPanel[] menuPanels, StandardUIMenuPanel defaultMenuPanel, bool useFirstResponseForMenuPortrait)
		{
		}

		protected void ClearCache()
		{
		}

		public virtual void SetActorMenuPanelNumber(DialogueActor dialogueActor, MenuPanelNumber menuPanelNumber)
		{
		}

		public void OverrideActorMenuPanel(Transform actorTransform, MenuPanelNumber menuPanelNumber, StandardUIMenuPanel customPanel)
		{
		}

		protected Transform GetActorTransformFromID(int actorID)
		{
			return null;
		}

		protected virtual StandardUIMenuPanel GetPanel(Subtitle lastSubtitle, Response[] responses)
		{
			return null;
		}

		protected StandardUIMenuPanel GetDialogueActorPanel(DialogueActor dialogueActor)
		{
			return null;
		}

		protected StandardUIMenuPanel GetPanelFromNumber(MenuPanelNumber menuPanelNumber, StandardUIMenuPanel customMenuPanel)
		{
			return null;
		}

		public override void SetPCPortrait(Sprite portraitSprite, string portraitName)
		{
		}

		public override void SetActorPortraitSprite(string actorName, Sprite portraitSprite)
		{
		}

		protected override void ClearResponseButtons()
		{
		}

		protected override void SetResponseButtons(Response[] responses, Transform target)
		{
		}

		public override void SetActive(bool value)
		{
		}

		public override void ShowResponses(Subtitle lastSubtitle, Response[] responses, Transform target)
		{
		}

		public virtual void MakeButtonsNonclickable()
		{
		}

		public void Close()
		{
		}

		public override void StartTimer(float timeout)
		{
		}

		public void DefaultTimeoutHandler()
		{
		}
	}
}
