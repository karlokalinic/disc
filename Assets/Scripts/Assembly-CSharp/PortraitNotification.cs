using UnityEngine;
using UnityEngine.UI;

public class PortraitNotification : MonoBehaviour
{
	[SerializeField]
	private Button button;

	[SerializeField]
	private Animator animator;

	private bool isActive;

	private static readonly int isEnabled;

	private static readonly int EnabledState;

	private static readonly int DisabledState;

	protected virtual void Start()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void OnClick()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void Refresh()
	{
	}

	public void StopAnimation()
	{
	}

	public bool StartAnimation(bool dialogueEnding = false)
	{
		return false;
	}
}
