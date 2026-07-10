using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class LevelManager : MonoBehaviour
	{
		public string defaultStartingLevel;

		public bool useAsyncLoad;

		public bool isLoading { get; private set; }

		public bool IsLoading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void LoadGame(string saveData)
		{
		}

		public void RestartGame()
		{
		}

		private IEnumerator LoadLevelFromSaveData(string saveData)
		{
			return null;
		}

		public void LoadLevel(string levelName)
		{
		}

		public void LoadLevel(int levelIndex)
		{
		}

		private IEnumerator LoadLevelCoroutine(string levelName, int levelIndex)
		{
			return null;
		}

		private bool CanLoadAsync()
		{
			return false;
		}

		public virtual void OnRecordPersistentData()
		{
		}
	}
}
