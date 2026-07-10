using UnityEngine;

namespace FortressOccident
{
	public class InteractableWithDialogueCursor : BaseCustomCursor
	{
		[SerializeField]
		protected CursorType InteractableCursor;

		[SerializeField]
		protected CursorType DialogueCursor;

		private BasicEntity basicEntity;

		protected override void Awake()
		{
		}

		protected override CursorType GetCustomCursor()
		{
			return null;
		}
	}
}
