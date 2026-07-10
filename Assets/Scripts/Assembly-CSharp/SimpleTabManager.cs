using System;
using UnityEngine;

public class SimpleTabManager : MonoBehaviour
{
	[Serializable]
	private class ButtonTabPair
	{
		public SimpleTabButton Button;

		public GameObject TabContentParent;
	}

	[SerializeField]
	private ButtonTabPair[] buttonTabPairs;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void SelectTab(int tabIndex)
	{
	}

	private void DeselectAllTabs()
	{
	}

	private void SelectTab(int tabIndex, bool isSelected)
	{
	}
}
