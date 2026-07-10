using System.Collections;
using System.Collections.Generic;
using FortressOccident;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnimDice : MonoBehaviour, IIdleAnimationFinished, IEventSystemHandler
{
	private const float PAIRED_IDLES_DELAY = 600f;

	public static bool L_DiceEquipped;

	public static bool R_DiceEquipped;

	public static bool somethingInTequilaRigthHand;

	public static bool somethingInTequilaLeftHand;

	public static bool inDialogue;

	public static bool animDiceLocked;

	public static bool isViewBlocked;

	public static bool isParalyzed;

	private static ItemBehaviour ItemInHand_L;

	private static ItemBehaviour ItemInHand_R;

	private static string[] NECK_TIES;

	private bool diceLock;

	private bool secondLock;

	private bool lockDown;

	private bool isTequila;

	public bool canMove;

	private int LoopCount;

	private int diceValue;

	private int newDiceValue;

	private Animator anim;

	private Character subjectChar;

	private CharacterNavigator charNav;

	private bool isMullenSetEquipped;

	private bool isRoyalistSetEquipped;

	private bool isExtremeSetEquipped;

	private float startIdleTime;

	[SerializeField]
	private float timeToNextIdle;

	private bool idleInProgress;

	private bool preparingForPairedIdle;

	private Vector3 companionPairedIdlePos;

	private Vector3 companionBeforeIdlePos;

	public int timerMin;

	public int timerMax;

	public int DiceMin;

	public int DiceMax;

	public List<GameObject> ListForDisappearingIdleItems;

	private Animator otherAnim;

	private WaitForSeconds delay;

	private WaitForSeconds tweenDelay;

	private int layerID_IdleLayer;

	private int layerID_PutAwayTool_L;

	private int layerID_PutAwayTool_R;

	private static readonly string state_PlayerMovementIdleName;

	private static readonly int endIdle;

	private static readonly int putAwayToolL;

	private static readonly int putAwayToolR;

	private static readonly int putOutToolL;

	private static readonly int putOutToolR;

	private static readonly int dice;

	private static readonly int isMullenSetEquippedHash;

	private static readonly int isExtremeSetEquippedHash;

	private static readonly int isRoyalistSetEquippedHash;

	private static WaitForSeconds WaitForSecond;

	private CharacterAnimator TequilaCharacterAnimator => null;

	private Vector3 kimPairedIdlesOffset => default(Vector3);

	private Vector3 cunoPairedIdlesOffset => default(Vector3);

	public bool IdleInProgress
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool PreparingForPairedIdle
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private static bool SomethingInTequilaHand => false;

	private bool IsIdleAnimationBlockedByHeldItem => false;

	private bool IsTieEquiped { get; set; }

	private bool IsMullenSetEquipped
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool IsExtremeSetEquipped
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool IsRoyalistSetEquipped
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void DiceStart()
	{
	}

	public void ThrowDice()
	{
	}

	public void StopThrowDice()
	{
	}

	private IEnumerator DiceCaster()
	{
		return null;
	}

	public bool CanPerformPairedIdle()
	{
		return false;
	}

	public bool IsPairedIdlePositionOnNavmesh()
	{
		return false;
	}

	public void PrepareForPairedIdle()
	{
	}

	private void OnHasArrivedAndPlayPairedAnimationEvent(Character character, bool hasReachedDestination)
	{
	}

	private IEnumerator MovingDice()
	{
		return null;
	}

	private float ResetTimeToNextIdle()
	{
		return 0f;
	}

	public void AnimatePutAwayLayerToTargetTween(float duration, float target)
	{
	}

	private IEnumerator DiceReset()
	{
		return null;
	}

	private bool ShouldIStopIdler()
	{
		return false;
	}

	private IEnumerator LayerTween()
	{
		return null;
	}

	private bool CheckNectieEquipped(string name, bool equipping)
	{
		return false;
	}

	private void OnItemEquipped(string name, EquipmentSlotType slotType, bool equipping)
	{
	}

	private bool CheckEquipped(string itemName, string itemToCheckName, bool equipping)
	{
		return false;
	}

	public static IEnumerator AnimDiceLockerCoroutine(float time)
	{
		return null;
	}

	public static void LockAnimDice()
	{
	}

	public static void UnlockAnimDice()
	{
	}

	void IIdleAnimationFinished.OnIdleAnimationExitState()
	{
	}

	private IEnumerator OnIdleAnimationFinished()
	{
		return null;
	}

	public static void SetLastEquipedItem(bool isRightHand, ItemBehaviour itemEquiped)
	{
	}
}
