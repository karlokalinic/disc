using UnityEngine;

namespace PixelCrushers
{
	public class AutoSaveLoad : MonoBehaviour
	{
		public int saveSlotNumber;

		public int[] dontSaveInScenes;

		public bool loadOnStart;

		public bool saveOnQuit;

		public bool saveOnPause;

		public bool saveOnLoseFocus;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private bool OnWantsToQuit()
		{
			return false;
		}

		private void CheckSaveOnQuit()
		{
		}

		private void OnApplicationPause(bool paused)
		{
		}

		private void OnApplicationFocus(bool focusStatus)
		{
		}

		private bool CanSaveInThisScene()
		{
			return false;
		}

		public void Restart(string startingSceneName)
		{
		}
	}
}
