using System.Collections.Generic;
using CollageMode;
using UnityEngine;
using UnityEngine.UI;

public class SavesSubdrawer : SubDrawer
{
	private const int SAVES_LIMIT = 20;

	[SerializeField]
	private SavesPanel panel;

	[SerializeField]
	[Space]
	private Button openButton;

	[SerializeField]
	private Button deleteButton;

	[SerializeField]
	private RectTransform staticButtons;

	[SerializeField]
	private SpecialSaveButton newSaveButton;

	[SerializeField]
	private SimpleHorizontalLayout simpleHorizontalLayout;

	private List<SaveButton> instantiatedButtons;

	private bool processing;

	private void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void Update()
	{
	}

	private void GetSaves(List<CollageSaveData> saves)
	{
	}

	private void OpenCurrentSave()
	{
	}

	private void SubmitSelectedButton()
	{
	}

	private void DeleteSave()
	{
	}

	private void CreateNewSave()
	{
	}

	private SaveButton GetButton()
	{
		return null;
	}

	private void EnableAddingNewSaves(bool value)
	{
	}
}
