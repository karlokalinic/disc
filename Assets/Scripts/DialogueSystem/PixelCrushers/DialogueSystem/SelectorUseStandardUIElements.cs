using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SelectorUseStandardUIElements : MonoBehaviour
	{
		[Serializable]
		public class TagInfo
		{
			public string tag;

			public string defaultUseMessage;

			public StandardUISelectorElements UIElements;
		}

		[Serializable]
		public class LayerInfo
		{
			public LayerMask layerMask;

			public string defaultUseMessage;

			public StandardUISelectorElements UIElements;
		}

		public List<TagInfo> tagSpecificElements;

		public List<LayerInfo> layerSpecificElements;

		private Selector selector;

		private ProximitySelector proximitySelector;

		private string defaultUseMessage;

		private Usable usable;

		private bool lastInRange;

		private AbstractUsableUI usableUI;

		private bool started;

		private string originalDefaultUseMessage;

		private StandardUISelectorElements elements;

		protected float CurrentDistance => 0f;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ConnectDelegates()
		{
		}

		private void DisconnectDelegates()
		{
		}

		private void SetElementsForUsable(Usable usable)
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
