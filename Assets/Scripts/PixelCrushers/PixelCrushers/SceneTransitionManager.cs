using System.Collections;
using UnityEngine;

namespace PixelCrushers
{
	public abstract class SceneTransitionManager : MonoBehaviour
	{
		public virtual IEnumerator LeaveScene()
		{
			return null;
		}

		public virtual IEnumerator EnterScene()
		{
			return null;
		}
	}
}
