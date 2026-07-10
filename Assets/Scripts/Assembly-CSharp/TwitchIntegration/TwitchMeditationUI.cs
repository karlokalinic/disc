using System.Collections;
using Sunshine.Metric;
using Sunshine.Views;
using TMPro;
using TwitchIntegration.Results;
using UnityEngine;
using UnityEngine.UI;

namespace TwitchIntegration
{
	public class TwitchMeditationUI : MonoBehaviour
	{
		[SerializeField]
		private Button meditationStart;

		[SerializeField]
		private TextMeshProUGUI timer;

		[SerializeField]
		private Image meditationInProgress;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private CharacterBuff buff;

		[SerializeField]
		private CharacterEffect buffEffect;

		[SerializeField]
		private CharacterBuff debuff;

		[SerializeField]
		private CharacterEffect debuffEffect;

		private Coroutine meditationPollTracker;

		private Coroutine meditationCooldownTracker;

		private Coroutine meditationBuffTimeTracker;

		private bool canMeditationBeUsed;

		private void Reset()
		{
		}

		private void Start()
		{
		}

		private void OnBuffStarted()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnTwitchEnableStateChanged(bool IsActive)
		{
		}

		private void ForceDisableMeditationFeature()
		{
		}

		private void RefreshMeditationButtonState()
		{
		}

		private void RefreshMeditationButtonState(ViewType viewType)
		{
		}

		public void StartMeditation()
		{
		}

		private void OnCreateMeditationPollRequestReturned(RequestResult obj)
		{
		}

		private void StopRunningCoroutines()
		{
		}

		private IEnumerator TrackMeditationCooldown()
		{
			return null;
		}

		private IEnumerator TrackMeditationPoll()
		{
			return null;
		}

		private IEnumerator TrackMeditationBuff()
		{
			return null;
		}

		private void OnCloseMeditationPullRequestReturned(MeditationPollRequestResult obj)
		{
		}

		private void MakeImageRedAfterFailedMeditationPoll()
		{
		}

		private static void DEBUG_KeybindForTesting()
		{
		}
	}
}
