using System.Collections.Generic;
using FortressOccident;
using Sunshine;
using UnityEngine;
using UnityEngine.Events;

public class LockedContainerSwitcher : MonoBehaviour
{
	private static readonly List<string> PRYING_TOOLS;

	public UnityEvent OnTryLockedContainer;

	private bool isContainerLocked;

	private MouseOverHighlight mouseOverHighlight;

	private ContainerSource container;

	public void Start()
	{
	}

	private void OnInventoryChange()
	{
	}

	private void ToggleContainerState(bool changeToLocked)
	{
	}
}
