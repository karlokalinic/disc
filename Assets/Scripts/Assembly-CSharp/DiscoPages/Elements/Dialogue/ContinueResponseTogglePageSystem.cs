using UnityEngine;
using Voidforge;

namespace DiscoPages.Elements.Dialogue
{
	public class ContinueResponseTogglePageSystem : SingletonComponent<ContinueResponseTogglePageSystem>
	{
		public bool showDebugInfo;

		public PeekLayout reactionsPeekLayout;

		public RectTransform optionsPanel;

		public RectTransform continueButton;

		private ConversationLoggerPageSystem convLogger;

		private static bool _sequencerLock;

		private static bool _isHeldForExistentialCrisis;

		private float delayCount;

		public float delaySeconds;

		private InteractionState state;

		private InteractionState targetState;

		public static bool SequencerLock
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool IsHeldForExistentialCrisis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public InteractionState State => default(InteractionState);

		public InteractionState TargetState
		{
			set
			{
			}
		}

		private bool IsChanging => false;

		private void Start()
		{
		}

		private void TargetChanged()
		{
		}

		public void ChooseState()
		{
		}

		private void Update()
		{
		}

		private void ContinueOnly()
		{
		}

		private void OptionsOnly()
		{
		}

		public void Nothing()
		{
		}

		private void ShowContinue()
		{
		}

		private void HideContinue()
		{
		}

		private void ShowOptions()
		{
		}

		private void HideOptions()
		{
		}
	}
}
