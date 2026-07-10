using InControl;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NavigationManager : LiteSingleton<NavigationManager>
{
	private enum Direction
	{
		Up = 0,
		Down = 1,
		Left = 2,
		Right = 3
	}

	private struct NavigateStepResult
	{
		public bool isFinal;

		public Selectable result;
	}

	public class SelectableEvent : UnityEvent<Selectable>
	{
	}

	private const float HOLD_DELAY = 0.4f;

	private const float REPEAT_DELAY = 0.07f;

	private float timer;

	private bool holdingNavigationInput;

	private bool isAfterHoldDelay;

	private PlayerAction lastNavigationAction;

	public SelectableEvent OnSelectionChanged;

	[SerializeField]
	private int maxFallthrough;

	private Selectable previousSelectable;

	public bool HoldingNavigationInput
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

	private void Update()
	{
	}

	public void Select(Selectable selectable)
	{
	}

	public void SelectNonGroupNavigation(Selectable selectable)
	{
	}

	public bool HaveAnythingSelected()
	{
		return false;
	}

	public bool IsSelected(Selectable selectable)
	{
		return false;
	}

	public void Deselect()
	{
	}

	private bool LastNavigationIsAnalog(PlayerAction lastAction)
	{
		return false;
	}

	private void HandleNavigationInput()
	{
	}

	private bool IsNavigationActionBeingInvoked(PlayerAction action)
	{
		return false;
	}

	private bool IsAnalogActionBeingInvoked(PlayerAction action)
	{
		return false;
	}

	public static bool IsRightNavigationButtonDown()
	{
		return false;
	}

	public static bool IsLeftNavigationButtonDown()
	{
		return false;
	}

	private void Submit()
	{
	}

	private void NavigateOrSelectPrevious(Selectable source, Direction direction)
	{
	}

	private void NavigateTo(Selectable source, Direction direction)
	{
	}

	private NavigateStepResult NavigateStep(Selectable source, Direction direction)
	{
		return default(NavigateStepResult);
	}

	private bool ShouldFallThrough(Selectable target)
	{
		return false;
	}

	private bool IsValidNavigationGroup(Selectable target)
	{
		return false;
	}

	private Selectable FindSelectableInDirection(Selectable source, Direction direction)
	{
		return null;
	}

	private Selectable GetCurrentSelectedSelectable()
	{
		return null;
	}
}
