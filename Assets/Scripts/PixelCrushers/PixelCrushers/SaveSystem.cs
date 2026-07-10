using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PixelCrushers
{
	public class SaveSystem : MonoBehaviour
	{
		public delegate void SceneLoadedDelegate(string sceneName, int sceneIndex);

		public const int NoSceneIndex = -1;

		public const string LastSavedGameSlotPlayerPrefsKey = "savedgame_lastSlotNum";

		[SerializeField]
		private bool m_saveCurrentScene;

		[SerializeField]
		private int m_framesToWaitBeforeApplyData;

		[SerializeField]
		private bool m_debug;

		private static SaveSystem m_instance;

		private static List<Saver> m_savers;

		private static SavedGameData m_savedGameData;

		private static DataSerializer m_serializer;

		private static SavedGameDataStorer m_storer;

		private static SceneTransitionManager m_sceneTransitionManager;

		private static GameObject m_playerSpawnpoint;

		private static int m_currentSceneIndex;

		private static List<string> m_addedScenes;

		private static AsyncOperation m_currentAsyncOperation;

		private static bool m_isQuitting;

		public static bool saveCurrentScene
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int framesToWaitBeforeApplyData
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool debug
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static SaveSystem instance => null;

		public static DataSerializer serializer => null;

		public static SavedGameDataStorer storer => null;

		public static SceneTransitionManager sceneTransitionManager => null;

		public static AsyncOperation currentAsyncOperation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static SavedGameData currentSavedGameData => null;

		public static GameObject playerSpawnpoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static int currentSceneIndex => 0;

		public static event SceneLoadedDelegate sceneLoaded
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

		public static event Action saveStarted
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

		public static event Action saveEnded
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

		public static event Action loadStarted
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

		public static event Action loadEnded
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

		private void Awake()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public static string GetCurrentSceneName()
		{
			return null;
		}

		public static int GetCurrentSceneIndex()
		{
			return 0;
		}

		private static IEnumerator LoadSceneInternal(string sceneName)
		{
			return null;
		}

		private static IEnumerator LoadSceneInternalTransitionCoroutine(string sceneName)
		{
			return null;
		}

		public static IEnumerator LoadAdditiveSceneInternal(string sceneName)
		{
			return null;
		}

		private static void RecursivelyApplySavers(Transform t)
		{
		}

		public static void UnloadAdditiveSceneInternal(string sceneName)
		{
		}

		public void SaveGameToSlot(int slotNumber)
		{
		}

		public void LoadGameFromSlot(int slotNumber)
		{
		}

		public void LoadSceneAtSpawnpoint(string sceneNameAndSpawnpoint)
		{
		}

		public static bool HasSavedGameInSlot(int slotNumber)
		{
			return false;
		}

		public static void DeleteSavedGameInSlot(int slotNumber)
		{
		}

		public static void SaveToSlot(int slotNumber)
		{
		}

		private static IEnumerator SaveToSlotCoroutine(int slotNumber)
		{
			return null;
		}

		private static void SaveToSlotNow(int slotNumber)
		{
		}

		public static void LoadFromSlot(int slotNumber)
		{
		}

		private static IEnumerator LoadFromSlotCoroutine(int slotNumber)
		{
			return null;
		}

		private static void NotifyLoadEndedWhenSceneLoaded(string sceneName, int sceneIndex)
		{
		}

		private static void LoadFromSlotNow(int slotNumber)
		{
		}

		public static void RegisterSaver(Saver saver)
		{
		}

		public static void UnregisterSaver(Saver saver)
		{
		}

		public static void ClearSavedGameData()
		{
		}

		public static SavedGameData RecordSavedGameData()
		{
			return null;
		}

		private static int GetSaverSceneIndex(Saver saver)
		{
			return 0;
		}

		public static void UpdateSaveData(Saver saver, string data)
		{
		}

		public static void ApplySavedGameData(SavedGameData savedGameData)
		{
		}

		public static void ApplySavedGameData()
		{
		}

		public static void BeforeSceneChange()
		{
		}

		public static void LoadGame(SavedGameData savedGameData)
		{
		}

		public static void LoadScene(string sceneNameAndSpawnpoint)
		{
		}

		private static IEnumerator LoadSceneCoroutine(SavedGameData savedGameData, string spawnpointName)
		{
			return null;
		}

		private static void ApplyDataImmediate()
		{
		}

		private void FinishedLoadingScene(string sceneName, int sceneIndex)
		{
		}

		public static void LoadAdditiveScene(string sceneName)
		{
		}

		public static void UnloadAdditiveScene(string sceneName)
		{
		}

		public static void RestartGame(string startingSceneName)
		{
		}

		private static void SaversRestartGame()
		{
		}

		public static string Serialize(object data)
		{
			return null;
		}

		public static T Deserialize<T>(string s, T data = default(T))
		{
			return default(T);
		}
	}
}
