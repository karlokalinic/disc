using UnityEngine.UI;

public class StaggeredGridLayout : GridLayoutGroup
{
	public override float preferredHeight => 0f;

	private bool IsStaggered(int index)
	{
		return false;
	}

	public override void SetLayoutHorizontal()
	{
	}

	public override void SetLayoutVertical()
	{
	}

	private void SetCellsAlongAxisStaggered(int axis)
	{
	}
}
