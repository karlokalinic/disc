using System.Collections;
using UnityEngine;

public class StatusNotificationDim : MonoBehaviour
{
	[SerializeField]
	private Animator animator;

	private bool isInitialized;

	private static readonly int EnabledState;

	private static readonly int DisabledState;

	private IEnumerator Start()
	{
		return null;
	}

	public void SetEnabled(bool isEnabled)
	{
	}

	private bool CanUseAnimator()
	{
		return false;
	}
}
