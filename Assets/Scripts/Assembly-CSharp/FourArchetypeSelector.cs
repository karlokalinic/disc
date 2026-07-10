using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FourArchetypeSelector : LiteSingleton<FourArchetypeSelector>
{
	public static bool ShowArchetypeOnLobbyLoad;

	public ArchetypeSelectButton ButtonTemplate;

	public Transform ButtonPanel;

	public ArchetypeSelectButton CustomCharacterButton;

	public SunshineCharacterTemplate[] archetypes;

	public Sprite[] portraits;

	public Button backButton;

	public ConventionTutorialScreenFiddler tutorialScreenTemplate;

	private ArchetypeSelectButton selectedArchetypeButton;

	public List<ArchetypeSelectButton> archetypeButtons;

	private bool gameStarted;

	protected override void Awake()
	{
	}

	public void SelectArchetype()
	{
	}

	private void InitializeButtons()
	{
	}

	public void SelectArchetype(ArchetypeSelectButton archetypeButton)
	{
	}

	public void OnArchetypeContinueButtonPressed()
	{
	}

	private void Continue()
	{
	}

	private void GoStart()
	{
	}

	private void GoCharCreator()
	{
	}

	public void NotifyActivation()
	{
	}

	public void NotifyDeactivation()
	{
	}

	private void SpawnTutorialScreen()
	{
	}
}
