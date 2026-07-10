using UnityEngine;

namespace PixelCrushers
{
	public abstract class TagMaskEvent : MonoBehaviour
	{
		public TagMask tagMask;

		public bool IsInTagMask(string tag)
		{
			return false;
		}
	}
}
