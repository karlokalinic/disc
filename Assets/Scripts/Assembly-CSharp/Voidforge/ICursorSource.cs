using UnityEngine;

namespace Voidforge
{
	public interface ICursorSource
	{
		Texture2D texture { get; }

		Vector2 hotspot { get; }
	}
}
