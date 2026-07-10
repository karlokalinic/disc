using UnityEngine;

public class CharsheetAnimatorHelper : MonoBehaviour
{
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private FlipClock[] flipClocks;

	private CharSheetMode lastCharsheetMode;

	public CharSheetMode CharsheetMode
	{
		get
		{
			return default(CharSheetMode);
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public void ShowFlipClock(int flipClockIndex)
	{
	}

	public void HideFlipClock(int flipClockIndex)
	{
	}
}
