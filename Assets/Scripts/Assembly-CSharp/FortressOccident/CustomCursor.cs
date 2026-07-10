using UnityEngine;
using Voidforge;

namespace FortressOccident
{
	public class CustomCursor : BaseCustomCursor
	{
		[SerializeField]
		protected CursorType cursor;

		[SerializeField]
		protected CursorType[] alternateCursors;

		protected ComponentRef<BaseParameter> parameter;

		protected override CursorType GetCustomCursor()
		{
			return null;
		}
	}
}
