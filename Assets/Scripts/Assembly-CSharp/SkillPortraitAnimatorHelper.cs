using UnityEngine;
using UnityEngine.UI;

public class SkillPortraitAnimatorHelper : MonoBehaviour
{
	public Image portrait;

	public Image portraitEffect;

	public Image rankImage;

	private Animator animator;

	[SerializeField]
	private float flickerRandomization;

	[SerializeField]
	private MaterialValueUpdater materialValueUpdater;

	private AnimatorCachedInt charsheetMode;

	private AnimatorCachedBool isShown;

	private AnimatorCachedBool isDimmed;

	private AnimatorCachedBool isSignature;

	private AnimatorCachedBool isSelected;

	private AnimatorCachedFloat flickerSpeed;

	private AnimatorCachedInt currentRank;

	private AnimatorCachedInt delta;

	private static int RESET_ANIMATION;

	public bool Animate { get; set; }

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

	public bool IsShown
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDimmed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsSignature
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsSelected
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float FlickerSpeed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int AnimatorTargetRank
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private int AnimatorCurrentRank
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private int AnimatorNewRank { get; set; }

	private int AnimatorDelta
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void ResetValues()
	{
	}

	public void ResetAnimator()
	{
	}

	public void OnIncreaseRankAnimationStarted()
	{
	}

	public void OnIncreaseRankAnimationFinished()
	{
	}

	public void OnDecreaseRankAnimationStarted()
	{
	}

	public void OnDecreaseRankAnimationFinished()
	{
	}

	private Sprite GetSpriteForRank(int rank)
	{
		return null;
	}

	private void RandomizeFlickerSpeed()
	{
	}
}
