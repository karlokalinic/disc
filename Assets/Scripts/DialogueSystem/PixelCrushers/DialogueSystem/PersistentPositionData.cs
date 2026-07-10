using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class PersistentPositionData : MonoBehaviour
	{
		public string overrideActorName;

		public bool recordCurrentLevel;

		[HideInInspector]
		public bool restoreCurrentLevelPosition;

		private string actorName => null;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void Start()
		{
		}

		public void OnRecordPersistentData()
		{
		}

		public void OnApplyPersistentData()
		{
		}

		private string GetPositionString()
		{
			return null;
		}

		private void ApplyPositionString(string s)
		{
		}

		public static string SanitizeLevelName(string levelName)
		{
			return null;
		}
	}
}
