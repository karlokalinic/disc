using DarkTonic.MasterAudio;
using FortressOccident;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Voidforge;

public class OrbUiElement : BasicEntity, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	private static SelectionCircleController selectionCircle;

	private static Vector2 normal;

	private static Vector2 extended;

	private static Vector2 controllerExtended;

	public OrbitPoint orbitPoint;

	public Image freshnessIndicator;

	public Image orbitEraser;

	public Image clickArea;

	public OrbAttentionPuller orbAttentionPuller;

	public AnimationCurve orbAnimation;

	public OrbVisibility visibility;

	[HideInInspector]
	public bool isAccessibleCached;

	private ComponentRef<RectTransform> rectTransform;

	private ComponentRef<Image> image;

	private ComponentRef<FloatFactory> floatFactory;

	private SenseOrb worldOrb;

	private bool isHovered;

	private float scaleMultiplier;

	private RectTransform parentRectTransform;

	private bool isAddedToUi;

	private Vector3 updatePosition;

	private Vector2 updateViewportPoint;

	private EventSounds evtSounds;

	public Vector3 OrbWorldPosition => default(Vector3);

	public float ScaleMultiplier
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public SenseOrb WorldOrb => null;

	public override Vector3 InteractionCenterPoint => default(Vector3);

	public override bool CanInteract => false;

	public bool ToBeDestroyed { get; protected set; }

	protected override float interactionRadius => 0f;

	protected override bool ResetInit => false;

	protected override void OnStartInitialized()
	{
	}

	protected override void OnSceneActivated()
	{
	}

	protected override void OnSceneDeactivated()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void RegisterOrb()
	{
	}

	private void UnregisterOrb()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	protected void Reset()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnOrbSelected()
	{
	}

	public void OnOrbDeselected()
	{
	}

	public void OnPointerClicked(PointerEventData eventData)
	{
	}

	public override bool Interact(ClickEventData data)
	{
		return false;
	}

	public override void OnUse(Transform user = null)
	{
	}

	public override void UpdateCache()
	{
	}

	public void Initialize(SenseOrb orb, InteractableRenderer interactableRenderer)
	{
	}

	private void ShowOrb()
	{
	}

	private void HideOrb()
	{
	}

	private void SpawnFloatText()
	{
	}

	public void OrbUIDestroy()
	{
	}

	public void OrbUIRestore()
	{
	}

	public override void ResetToDefault()
	{
	}

	public void SetShown()
	{
	}

	public void UpdateVisuals()
	{
	}

	public void Open()
	{
	}

	private void Animate()
	{
	}

	private void InitialState()
	{
	}

	private void ClickRegistered()
	{
	}

	private void SetDialogueCursor()
	{
	}

	private void MaybeShowFreshnessIndicator()
	{
	}

	private void HideFreshnessIndicator()
	{
	}

	private void ChooseAlpha(OrbVisibility state)
	{
	}

	private void SetBackgroundAlpha(float f)
	{
	}

	protected GameObject SpawnAnchor()
	{
		return null;
	}
}
