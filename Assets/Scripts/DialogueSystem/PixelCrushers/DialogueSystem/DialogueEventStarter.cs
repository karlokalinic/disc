using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public abstract class DialogueEventStarter : MonoBehaviour
	{
		public bool once;

		protected virtual bool useOnce => false;

		protected void DestroyIfOnce()
		{
		}
	}
}
