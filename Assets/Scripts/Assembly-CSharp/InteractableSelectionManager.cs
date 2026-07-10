using System;
using System.Collections.Generic;
using FortressOccident;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class InteractableSelectionManager
{
	public class InteractableChangedEvent : UnityEvent<CommonPadInteractable>
	{
	}

	private float m_interactableMaxDistance;

	private float m_nextInteractionMaxAngle;

	private float m_timeToLoseSelection;

	private Dictionary<int, CommonPadInteractable> m_availableInteractables;

	private CommonPadInteractable m_currentySelected;

	private float m_timeSinceSelectionChanged;

	public InteractableChangedEvent OnInteractableChanged;

	public InteractableChangedEvent OnInteractableAdded;

	public InteractableChangedEvent OnInteractableRemoved;

	public bool HasInteractables => false;

	public CommonPadInteractable CurrentSelected
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InteractableSelectionManager(float interactableMaxDistance, float nextInteractionMaxAngle, float timeToLoseSelection)
	{
	}

	public void OnUpdate()
	{
	}

	public void OnNonControllerUpdate()
	{
	}

	public void Add(OrbUiElement orb, float distance)
	{
	}

	public void Add(MouseOverHighlight interactable, float distance)
	{
	}

	public bool Interact(bool forceRun = false)
	{
		return false;
	}

	public void GetNextInteractableInDirection(Vector3 characterPosition, Vector2 direction)
	{
	}

	private bool CheckIfNeedToResetCurrentSelected(Vector3 characterPosition)
	{
		return false;
	}

	private CommonPadInteractable SelectClosestToPositionInDirection(Vector3 lastSelectionPosition, Vector2 direction)
	{
		return null;
	}

	private void RemoveAllInteractablesOnThisList(List<int> interactablesToRemove)
	{
	}

	public void Destroy()
	{
	}

	public void ClearInteractableDictionary()
	{
	}

	public void PrintDebug()
	{
	}
}
