using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollRectsControllerInput : LiteSingleton<ScrollRectsControllerInput>
{
	[SerializeField]
	private float deadlock;

	[SerializeField]
	private float scrollSpeed;

	private readonly List<ScrollRect> selectedScrolls;

	private void LateUpdate()
	{
	}

	public void EnableScrollInput(ScrollRect scroll)
	{
	}

	public void DisableScrollInput(ScrollRect scroll)
	{
	}
}
