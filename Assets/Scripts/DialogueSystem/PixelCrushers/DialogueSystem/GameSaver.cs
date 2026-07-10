using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class GameSaver : MonoBehaviour
	{
		public enum FunctionOnUse
		{
			None = 0,
			Save = 1,
			Load = 2,
			Restart = 3
		}

		public string playerPrefsKey;

		public int slot;

		public FunctionOnUse functionOnUse;

		public bool includeAllItemData;

		public bool includeLocationData;

		public bool includeSimStatus;

		public string startingLevel;

		public bool dontDestroyOnLoad;

		public void Awake()
		{
		}

		public void OnUse()
		{
		}

		public void SaveGame(int slot)
		{
		}

		public void SaveGame()
		{
		}

		public void LoadGame(int slot)
		{
		}

		public void LoadGame()
		{
		}

		public void SaveGame(string slotString)
		{
		}

		public void LoadGame(string slotString)
		{
		}

		public void RestartGame()
		{
		}

		private LevelManager FindLevelManager()
		{
			return null;
		}

		private int StringToSlot(string slotString)
		{
			return 0;
		}

		public void Record()
		{
		}

		public void Apply()
		{
		}
	}
}
