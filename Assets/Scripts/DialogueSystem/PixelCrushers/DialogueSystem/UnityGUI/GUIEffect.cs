using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public abstract class GUIEffect : MonoBehaviour
	{
		public GUIEffectTrigger trigger;

		public abstract IEnumerator Play();

		public virtual void Stop()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}
	}
}
