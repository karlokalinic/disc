using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ShowCursorOnConversation : MonoBehaviour
	{
		private bool wasCursorVisible;

		private CursorLockMode savedLockState;

		public void OnConversationStart(Transform actor)
		{
		}

		private IEnumerator ShowCursorAfterOneFrame()
		{
			return null;
		}

		public void OnConversationEnd(Transform actor)
		{
		}
	}
}
