using System.Collections.Generic;
using FortressOccident;

public class InteractableManager
{
	private List<CommonPadInteractable> m_availableInteractables;

	private List<CommonPadInteractable> m_currentInteractables;

	private int m_currentOption;

	public bool HasInteractables => false;

	public CommonPadInteractable CurrentSelected => null;

	public void Reset()
	{
	}

	public void MoveNext()
	{
	}

	public void MovePrevious()
	{
	}

	public bool Interact()
	{
		return false;
	}

	public bool AddInteractableToList(OrbUiElement orb, float sortFactor)
	{
		return false;
	}

	public bool AddInteractableToList(MouseOverHighlight interactable, float sortFactor)
	{
		return false;
	}

	public void SortAndSelect()
	{
	}

	public void DumpListedInteractables()
	{
	}

	public void Destroy()
	{
	}
}
