using System.Collections;
using FortressOccident;
using UnityEngine;

public class CharacterRotator : LiteSingleton<CharacterRotator>
{
	private const float PROFILE_ANGLE_VALUE = 45f;

	private const string FORWARD_PARAMETER = "Forward";

	[SerializeField]
	private AnimationCurve rotationCurve;

	[Space]
	[SerializeField]
	private bool rotateAtInventoryOpen;

	[SerializeField]
	private bool rotateAtInventoryClose;

	[Space]
	[SerializeField]
	private float profileRotationDuration;

	[SerializeField]
	private float backRotationDuration;

	[Space]
	[SerializeField]
	private float mouseRotationSpeed;

	private Character character;

	private bool isLocked;

	private float lastMousePosX;

	private Vector3 leftProfileEuler;

	private Vector3 rightProfileEuler;

	private Vector3 eulersAtInventoryOpen;

	public bool IsLocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnInventoryOpen()
	{
	}

	public void OnInventoryClose()
	{
	}

	private void MouseRotateCharacter()
	{
	}

	private void ControllerRotateCharacter()
	{
	}

	private void RotateToClosestProfile()
	{
	}

	private void RotateBackToStartEulers()
	{
	}

	private IEnumerator CurveRotateCharacter(Vector3 originEuler, Vector3 targetEuler, float duration)
	{
		return null;
	}

	private bool CharacterIsMoving()
	{
		return false;
	}

	private bool CharacterProfileVisible()
	{
		return false;
	}
}
