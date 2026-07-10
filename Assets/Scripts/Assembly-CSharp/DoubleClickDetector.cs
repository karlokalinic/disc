using UnityEngine.Events;

public class DoubleClickDetector
{
	private float doubleClickTolerance;

	private float initialPressDown;

	public UnityEvent OnDoubleClickDetected;

	public DoubleClickDetector(UnityAction actionOnDoubleClickDetected)
	{
	}

	public void OnButtonPressedDown()
	{
	}
}
