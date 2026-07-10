using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HudMainMenuButtonTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private enum State
	{
		Hidden = 0,
		Shown = 1
	}

	[SerializeField]
	private RectTransform buttonRectTransform;

	[SerializeField]
	private Button menuButton;

	[SerializeField]
	private Button helpButton;

	[SerializeField]
	private RectTransform hoverRectTransform;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private RectTransform shownTransform;

	[SerializeField]
	private RectTransform hiddenTransform;

	[SerializeField]
	private float transitionDuration;

	[SerializeField]
	private Ease easeType;

	private Sequence sequence;

	private Vector2 buttonHiddenAnchoredPos;

	private Vector2 buttonShownAnchoredPos;

	private State curHudState;

	private State curMenuButtonState;

	private bool isShowingMenu;

	private bool mouseOverDeteced;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private bool IsOnConsole()
	{
		return false;
	}

	public void ShowHub()
	{
	}

	public void HideHub()
	{
	}

	private void ShowMenuButton()
	{
	}

	private void HideMenuButton()
	{
	}

	private void OnMenuButtonPressed()
	{
	}

	private void HelpKeyHandler()
	{
	}

	void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
	{
	}

	void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
	{
	}
}
