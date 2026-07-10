using System.Collections.Generic;
using FortressOccident;
using InControl;
using PixelCrushers.DialogueSystem.Wrappers;
using Radial;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnalogueControl : LiteSingleton<CharacterAnalogueControl>
{
	private const float OrbDegreeAngle = 20f;

	private const float OrbRadianAngle = 0.34906584f;

	private const float ZoomMin = 0.27f;

	private const float ZoomMax = 0.71f;

	private const float ThresholdMax = 0.25f;

	private const float ThresholdMin = 0.55f;

	private const float ScreenTolerance = 0.1f;

	private float _doubleTapTimeD;

	public float ArrowCompensation;

	public Transform Tequila;

	public Vector3 pointNav;

	public GameObject RadialMenu;

	public GameObject InteractPrompt;

	public GameObject pointLook;

	public float interactableMaxDistanceInside;

	public float interactableMaxDistanceOutside;

	public Vector3 interactableRadiusOffset;

	private RadialMenu InvMenusControl;

	private float distanceInteract;

	private float nextInteractionMaxAngle;

	private float timeToLoseSelection;

	public float timeToStopAutoHighlight;

	public bool ToggleSprint;

	public bool pressHoldSprint;

	public bool isContainerActive;

	public bool isFlashlightActive;

	public Material ArrowMat;

	public GameObject Trigger;

	private NavMeshHit navHit;

	private bool forcePos;

	private bool forceStop;

	private bool addDelay;

	private bool addDelayMovement;

	private bool canControl;

	private bool doIt;

	private bool forcedisableicon;

	private float timer;

	private Character TequilaParentLogic;

	private float arrowAngle;

	public RaycastHit[] interactionHits;

	private OrbUiElement m_orbitalOrb;

	private GameObject ArrowObj;

	private GameObject InteractablesPromptObj;

	private GameObject ball;

	private InteractableSelectionManager m_interactableSelectionManager;

	private InteractableAutoHighlightManager m_interactableAutoHighlightManager;

	private TextMeshProDialogueUI tmpProDialogue;

	private bool m_interactableSelectionTilt;

	private Queue<MouseOverHighlight> mouseOverHighlightQueue;

	public InteractableAutoHighlightManager AutoHighlightsManager => null;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public void UpdatePropmtPosition()
	{
	}

	private void UITopTabPressedSelectMenuInDirection(int startPosition, int direction)
	{
	}

	private bool UITopTabPressedTrySelectMainView(int selectionId)
	{
		return false;
	}

	private void PlaceInteractablePromptOnCurrentlySelected()
	{
	}

	private void DoChangedTargetEffects(CommonPadInteractable newSelection)
	{
	}

	public void ForceStopMovement()
	{
	}

	private void CheckOrbitalOrbs()
	{
	}

	private Vector2 WorldToNDC(Vector3 worldPos)
	{
		return default(Vector2);
	}

	private void CheckInteractableByCapsuleCast(Vector2 tequilaScreen)
	{
	}

	private void CheckInteractablesScreenSpace()
	{
	}

	private void OnInputTypeChanged(BindingSourceType bindingSourceType)
	{
	}

	private static bool CheckIfScreenPointIsVisible(float widthTolerance, float heightTolerance, Vector2 interactableScreenPos)
	{
		return false;
	}

	private void CheckOrbInteractability(Vector2 tequilaScreenNormalized)
	{
	}

	private Vector2 GetRotatedVectorFrom(Vector3 original, float angle)
	{
		return default(Vector2);
	}

	private Vector3 SearchNearPoint()
	{
		return default(Vector3);
	}

	public static float GetPathLength(NavMeshPath path)
	{
		return 0f;
	}

	public void resetFlashlightPos()
	{
	}

	private void resetAddDelay()
	{
	}

	private void StopForceStop()
	{
	}

	private void ForceStop()
	{
	}

	private void resetDelayMovement()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDialogWindowContentChanged()
	{
	}
}
