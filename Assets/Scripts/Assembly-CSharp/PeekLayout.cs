using UnityEngine;

public class PeekLayout : MonoBehaviour
{
	public RectTransform visibleRect;

	public RectTransform hiddenRect;

	public RectTransform placeholderTemplate;

	public RectTransform firstElement;

	public RectTransform lastElement;

	public RectTransform testElement;

	private RectTransform currentPlaceholder;

	public void Stash(RectTransform target)
	{
	}

	public void Unstash(RectTransform target)
	{
	}

	public void HideWithPlaceholder(RectTransform original)
	{
	}

	public void ShowPlaceholder(RectTransform original)
	{
	}

	private void TestStash()
	{
	}

	private void TestUnstash()
	{
	}

	private void TestPlaceholder()
	{
	}
}
