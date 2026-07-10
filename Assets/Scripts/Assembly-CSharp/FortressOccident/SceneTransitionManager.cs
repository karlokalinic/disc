using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Voidforge;

namespace FortressOccident
{
	public class SceneTransitionManager : SingletonComponent<SceneTransitionManager>
	{
		private struct LiveAgent
		{
			public NavMeshAgent agent;

			public Character character;

			public LiveAgent(NavMeshAgent agent, Character character)
			{
				this.agent = null;
				this.character = null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}
		}

		public ColorFiller colorFiller;

		public TweenAlpha loadingScreen;

		public AnimationCurve showLoadingScreen;

		public AnimationCurve hideLoadingScreen;

		public Image loadingPanelImage;

		private static HashSet<object> loadingScreenDelays;

		public static PrioritizedActionList readyEvent;

		public static PrioritizedActionList notReadyEvent;

		public static UnityEvent OnMapChangedDuringGameplay;

		public static UnityEvent OnAreaChangeBeforePlacingCharacter;

		public static UnityEvent OnAreaChanged;

		public static bool IsReady { get; private set; }

		public static bool IsQuitting => false;

		public event Action OnTransitionFinish
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static bool AddLoadingScreenDelay(object delayingObj)
		{
			return false;
		}

		public static bool RemoveLoadingScreenDelay(object delayingObj)
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public static void Load(string sceneName, string destinationId, bool isGameLoad, bool showLoadingScreen, bool hideLoadingScreen)
		{
		}

		public static Coroutine UnloadAsync(List<string> sceneList, int count)
		{
			return null;
		}

		public void ShowLoadingScreen()
		{
		}

		public void HideLoadingScreen()
		{
		}

		private void OnMapChanged()
		{
		}

		private Texture2D GetScreenTexture()
		{
			return null;
		}

		private void PlatformTweakLightShadows()
		{
		}

		private void TransitionProcessScene(Scene scene)
		{
		}

		private void SetActive(Scene scene, bool state)
		{
		}

		public void SetLobby()
		{
		}

		private void ShowMainMenuCorrectly()
		{
		}

		private IEnumerator LoadSceneCoR(string sceneName, string destinationId, bool showLoadingScreen, bool hideLoadingScreen, bool isMapChanging = false)
		{
			return null;
		}

		public IEnumerator ShowLoadingScreenCoR(bool show, bool useSavePanel = false)
		{
			return null;
		}

		private IEnumerator UnloadScenesCoR(List<string> sceneList, int count)
		{
			return null;
		}

		public void Start()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
