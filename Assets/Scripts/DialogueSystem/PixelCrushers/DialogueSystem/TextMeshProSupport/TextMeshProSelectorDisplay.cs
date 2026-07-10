using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	public class TextMeshProSelectorDisplay : MonoBehaviour
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;

			public string hideTrigger;
		}

		public Graphic mainGraphic;

		public TextMeshProUGUI nameText;

		public TextMeshProUGUI useMessageText;

		public Color inRangeColor;

		public Color outOfRangeColor;

		public Graphic reticleInRange;

		public Graphic reticleOutOfRange;

		public AnimationTransitions animationTransitions;

		private Selector selector;

		private ProximitySelector proximitySelector;

		private string defaultUseMessage;

		private Usable usable;

		private bool lastInRange;

		private UsableUnityUI usableUnityUI;

		private Animator animator;

		private bool started;

		protected float CurrentDistance => 0f;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		public void FindUIElements()
		{
		}

		private TextMeshProSelectorElements SearchForElements(Transform t)
		{
			return null;
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void ConnectDelegates()
		{
		}

		private void DisconnectDelegates()
		{
		}

		private void OnSelectedUsable(Usable usable)
		{
		}

		private void OnDeselectedUsable(Usable usable)
		{
		}

		private string GetUseMessage()
		{
			return null;
		}

		private void ShowControls()
		{
		}

		private void HideControls()
		{
		}

		private void DeactivateControls()
		{
		}

		private bool IsUsableInRange()
		{
			return false;
		}

		public void Update()
		{
		}

		public void OnConversationStart(Transform actor)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		private void UpdateDisplay(bool inRange)
		{
		}

		private void UpdateText(bool inRange)
		{
		}

		private void UpdateReticle(bool inRange)
		{
		}

		private bool CanTriggerAnimations()
		{
			return false;
		}
	}
}
