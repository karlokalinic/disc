using System.Collections;
using UnityEngine;

namespace FortressOccident
{
	public class Curtains : Door
	{
		public string openingSoundGroup;

		public string openingSound;

		private SkinnedMeshRenderer skinnedMeshRenderer;

		private float startTime;

		protected override void OnAwakeInitialized()
		{
		}

		protected override void VisualTransitionDoor()
		{
		}

		protected override void UpdateDoorState()
		{
		}

		public IEnumerator MoveDoor(bool open)
		{
			return null;
		}

		public static void OpenBookstoreCurtains()
		{
		}

		protected override void CloseDoorsOnLevelTransition()
		{
		}
	}
}
