using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class PersistentDestructible : MonoBehaviour
	{
		public enum RecordOn
		{
			Destroy = 0,
			Disable = 1
		}

		public RecordOn recordOn;

		public string variableName;

		public GameObject spawnWhenDestroyed;

		protected bool listenForOnDestroy;

		protected string ActualVariableName => null;

		protected virtual void OnEnable()
		{
		}

		public void OnApplyPersistentData()
		{
		}

		public void OnLevelWillBeUnloaded()
		{
		}

		public void OnApplicationQuit()
		{
		}

		public void OnDestroy()
		{
		}

		private void MarkDestroyed()
		{
		}

		public void OnDisable()
		{
		}

		private void SpawnCorpse()
		{
		}
	}
}
