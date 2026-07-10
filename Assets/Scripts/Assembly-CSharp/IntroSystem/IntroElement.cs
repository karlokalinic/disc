using UnityEngine;

namespace IntroSystem
{
	public abstract class IntroElement : MonoBehaviour
	{
		public bool willFadeIn;

		public bool willFadeOut;

		public bool canBeSkipped;

		public bool willCutFadeOutAtSkip;

		public float fadeInDuration;

		public float fadeOutDuration;

		public float displayDuration;

		public virtual ElementType elementType => default(ElementType);

		public virtual T GetContent<T>()
		{
			return default(T);
		}
	}
}
