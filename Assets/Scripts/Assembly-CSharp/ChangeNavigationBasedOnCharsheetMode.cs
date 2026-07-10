using System;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNavigationBasedOnCharsheetMode : MonoBehaviour
{
	[Serializable]
	public struct ChangeableNavigation
	{
		public CharSheetMode charSheetMode;

		public Navigation newNavigation;
	}

	public ChangeableNavigation[] listOfNavigations;

	private Selectable target;

	private Navigation defaultNavigation;

	private CharsheetView Charsheet => null;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnViewModeChanged(CharSheetMode newMode)
	{
	}
}
