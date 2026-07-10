using UnityEngine.Video;

namespace IntroSystem
{
	public class IntroVideo : IntroElement
	{
		public VideoClip video;

		public override ElementType elementType => default(ElementType);

		public override T GetContent<T>()
		{
			return default(T);
		}
	}
}
