using System.Collections.Generic;
using FortressOccident;
using UnityEngine;

namespace DiscoPages.Elements.HUD
{
	public class PartyVisualizerPageSystem : MonoBehaviour
	{
		private static PartyVisualizerPageSystem singleton;

		public PortraitVisualizer tequilaPortrait;

		public PortraitVisualizer companionPortrait;

		public List<PortraitVisualizer> portraitVisualizers;

		private static bool ready;

		public static PartyVisualizerPageSystem Singleton => null;

		private void Awake()
		{
		}

		public void Start()
		{
		}

		private void RefreshTequila()
		{
		}

		private void DialogueBundleLoaded()
		{
		}

		private void Populate()
		{
		}

		private void Clean()
		{
		}

		public void Refresh()
		{
		}

		public void ShowNotification(PortraitNotificationType type)
		{
		}

		private void ShowtNotification(PortraitNotificationType type, string actor)
		{
		}

		public void HideNotification(PortraitNotificationType type)
		{
		}

		private void HideNotification(PortraitNotificationType type, string actor)
		{
		}

		public void PausePortraitAnimations()
		{
		}

		public void ResumePortraitAnimations(bool dialogueEnding = false)
		{
		}

		private void AddPortrait(Character character, string name, PortraitVisualizer portrait)
		{
		}
	}
}
