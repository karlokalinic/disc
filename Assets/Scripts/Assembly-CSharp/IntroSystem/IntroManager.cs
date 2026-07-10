using System.Collections;
using System.Collections.Generic;
using FortressOccident;
using Sunshine;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace IntroSystem
{
	public class IntroManager : MonoBehaviour
	{
		public bool TurnedOn;

		public const string SKIP_INTRO_PREF = "SkipIntro";

		[SerializeField]
		private GameObject introCanvas;

		[SerializeField]
		private FadeScreen fadeScreen;

		[SerializeField]
		private VideoPlayer videoPlayer;

		[SerializeField]
		private Image backgroundImage;

		[SerializeField]
		private Image introImage;

		[SerializeField]
		private ApplicationManager applicationManager;

		[SerializeField]
		private LobbyFade lobbyFade;

		[SerializeField]
		private VideoStream introVideoStream;

		[SerializeField]
		private AreaManager initSceneLoaded;

		[Space]
		[SerializeField]
		private List<IntroElement> introElements;

		[SerializeField]
		[Space]
		private List<GameObject> objectsToActivate;

		[SerializeField]
		private float delayBetweenIntroElements;

		private bool skipCurrentIntroElement;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void OnLoadCompleted()
		{
		}

		private IEnumerator PlayIntroSequence()
		{
			return null;
		}

		private void PostIntroSequence()
		{
		}

		private IEnumerator ShowIntroSprite(IntroSprite introSprite)
		{
			return null;
		}

		private IEnumerator ShowIntroVideo(IntroVideo introVideo)
		{
			return null;
		}
	}
}
