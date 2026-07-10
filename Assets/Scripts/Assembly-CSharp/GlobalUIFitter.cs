using UnityEngine;

public class GlobalUIFitter : MonoBehaviour
{
	public static GlobalUIFitter Singleton;

	private RectTransform rectTransform;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnOverscanChanged(float per, float size)
	{
	}

	public static void RefreshAspect(Aspect aspect)
	{
	}
}
