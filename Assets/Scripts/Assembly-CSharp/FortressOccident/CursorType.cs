using UnityEngine;

namespace FortressOccident
{
	[CreateAssetMenu]
	public class CursorType : ScriptableObject
	{
		public Texture2D cursorSprite;

		public Vector2 hotspot;
	}
}
