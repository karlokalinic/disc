using UnityEngine;

namespace IntroSystem
{
	public class IntroSprite : IntroElement
	{
		public Sprite sprite;

		public override ElementType elementType => default(ElementType);

		public override T GetContent<T>()
		{
			return default(T);
		}
	}
}
