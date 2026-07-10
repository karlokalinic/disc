using System.Collections.Generic;
using FortressOccident;
using UnityEngine;
using Voidforge;

public class PartyVisualizer : SingletonComponent<PartyVisualizer>
{
	public PortraitVisualizer portraitTemplate;

	public RectTransform padding;

	public PartyFeldVisualizer feldComponent;

	public List<PortraitVisualizer> portraitVisualizers;

	private static bool ready;

	public void Start()
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	private void RefreshTequila()
	{
	}

	private void DialogueBundleLoaded()
	{
	}

	private void Populate()
	{
	}

	private void Clean()
	{
	}

	public void Refresh()
	{
	}

	public void ShowNotification(PortraitNotificationType type)
	{
	}

	private void ShowtNotification(PortraitNotificationType type, string actor)
	{
	}

	public void HideNotification(PortraitNotificationType type)
	{
	}

	private void HideNotification(PortraitNotificationType type, string actor)
	{
	}

	public void PausePortraitAnimations()
	{
	}

	public void ResumePortraitAnimations(bool dialogueEnding = false)
	{
	}

	private void AddPortrait(Character character, string name, PortraitVisualizer template)
	{
	}
}
