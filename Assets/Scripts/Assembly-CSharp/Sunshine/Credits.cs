using System.Collections;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using Voidforge;

namespace Sunshine
{
	public class Credits : LiteSingleton<Credits>
	{
		[SerializeField]
		private Button closeButton;

		[SerializeField]
		private PlayableAsset idleState;

		[SerializeField]
		private PlayableAsset showState;

		private PlayableDirector animationDirector;

		private float prevTimeScale;

		private bool isTransitionToLobby;

		private bool creditsInProgress;

		public bool CreditsInProgress
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		public void ShowCredits()
		{
		}

		public void HideCredits()
		{
		}

		private void ConsumeAllInputEvents(InputManager.EventData data)
		{
		}

		private void Enable()
		{
		}

		private void Disable()
		{
		}

		private void PauseGame()
		{
		}

		private void ResumeGame()
		{
		}

		public void ReturnToLobby()
		{
		}

		private IEnumerator DoComeBackToLobby()
		{
			return null;
		}

		private void LoadLobby()
		{
		}

		private void FadeBackAfterTransition()
		{
		}

		public void SilenceAmbience(float fadeTime)
		{
		}

		public void BringBackAmbience(float fadeTime)
		{
		}

		public void ChangeTrack(string newSongName)
		{
		}

		public static void RegisterEscapeKeyListener()
		{
		}

		public static void UnregisterEscapeKeyListener()
		{
		}

		private void CloseOnConsolePauseButton()
		{
		}

		private static void CloseOnEscapeKey(InputManager.EventData data)
		{
		}
	}
}
