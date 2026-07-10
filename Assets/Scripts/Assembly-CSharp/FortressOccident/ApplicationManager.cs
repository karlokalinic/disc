using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Voidforge;

namespace FortressOccident
{
	[CreateAssetMenu]
	public class ApplicationManager : SingletonScriptable<ApplicationManager>
	{
		private const string LOBBY_SCENE_NAME = "Scenes/Lobby";

		public List<SceneProperties> ScenePropertiesList;

		public SceneProperties CurrentSceneProperties { get; set; }

		public bool IsGameArea => false;

		public bool GetDisplayNameIfStringHasSaveGameId(string saveFilename, out string displayName, out string saveGameId)
		{
			displayName = null;
			saveGameId = null;
			return false;
		}

		public bool GetSaveGameIdIfStringHasSaveDisplayName(string displayFilename, out string displayName, out string saveGameId)
		{
			displayName = null;
			saveGameId = null;
			return false;
		}

		public string GetAreaId()
		{
			return null;
		}

		public void ChangeArea(string areaId, string destinationId, bool isGameLoad, bool showLoadingScreen, bool hideLoadingScreen)
		{
		}

		public void LoadLobby(bool returnToLobby = false)
		{
		}

		public void LoadCredits()
		{
		}

		public void OnStartCompleted()
		{
		}

		private void OnBundleWasLoaded()
		{
		}

		public static Scene GetScene(string sceneName)
		{
			return default(Scene);
		}

		public static string GetScenePath(string sceneName)
		{
			return null;
		}
	}
}
