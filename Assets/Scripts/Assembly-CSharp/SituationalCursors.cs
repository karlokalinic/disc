using FortressOccident;
using UnityEngine;

public class SituationalCursors : MonoBehaviour
{
	public static SituationalCursors Singleton;

	[SerializeField]
	private CursorType loadingCursor;

	[SerializeField]
	private CursorType dragDropCursor;

	[SerializeField]
	private CursorType itemHoverCursor;

	public object LastRequester { get; private set; }

	public CursorType GetLoadingCursor(object requester = null)
	{
		return null;
	}

	public CursorType GetDragDropCursor(object requester = null)
	{
		return null;
	}

	public CursorType GetItemHoverCursor(object requester = null)
	{
		return null;
	}

	public void Start()
	{
	}
}
