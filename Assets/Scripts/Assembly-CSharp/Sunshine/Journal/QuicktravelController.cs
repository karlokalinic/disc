using System.Collections.Generic;
using UnityEngine;

namespace Sunshine.Journal
{
	public class QuicktravelController : MonoBehaviour
	{
		private static QuicktravelController singleton;

		[SerializeField]
		private CanvasGroup canvasGroup;

		public QuicktravelButton churchButton;

		public QuicktravelButton fishingVillageButton;

		public QuicktravelButton martinaiseButton;

		[HideInInspector]
		public bool wasQuicktravelChurchDiscovered;

		[HideInInspector]
		public bool wasQuicktravelFishingVillageDiscovered;

		private bool _isActive;

		private static Dictionary<string, QuicktravelButton> quicktravelButtonsDict;

		public static QuicktravelController Singleton => null;

		public static Dictionary<string, QuicktravelButton> QuicktravelButtonsDict => null;

		private bool IsActive
		{
			set
			{
			}
		}

		public void Initialize()
		{
		}

		public static void ResetQuicktravel()
		{
		}

		private void OnMarkerVisited(string markerTag)
		{
		}

		public void OnEnable()
		{
		}

		private bool IsQuicktravelAvailable()
		{
			return false;
		}

		private bool IsOutside()
		{
			return false;
		}

		private bool IsNotInDialogue()
		{
			return false;
		}

		private bool IsTequilaAbleToMove()
		{
			return false;
		}

		private bool IsWithingQuicktravelRange()
		{
			return false;
		}

		private bool IsNotBeforeTribunal()
		{
			return false;
		}
	}
}
