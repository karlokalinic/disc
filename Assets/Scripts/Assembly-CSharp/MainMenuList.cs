using System;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuList : MonoBehaviour
{
	public RectTransform topPadding;

	public RectTransform botPadding;

	public MainMenuButton menuItemTemplate;

	public RectTransform menuSeparatorTemplate;

	private GameLevelCommand commands;

	public static List<MainMenuButton> selectByDefault;

	public static List<MainMenuButton> menuButtons;

	public void Start()
	{
	}

	private MainMenuButton CreateButton(string label, string localizationTerm, Func<bool> canBeUsedFunction = null, Func<bool> shouldBeDisabledIfCanNotBeUsed = null, Func<bool> OverrideCanBeUsedFunction = null)
	{
		return null;
	}

	private void HideAllHovers()
	{
	}

	private void Separator()
	{
	}

	private void Continue()
	{
	}

	public static bool IsContinueShown()
	{
		return false;
	}

	public static bool IsLoadShown()
	{
		return false;
	}

	private void New()
	{
	}

	private void Save()
	{
	}

	private void QuickSave()
	{
	}

	private void Load()
	{
	}

	private void Options()
	{
	}

	private void CollageMode()
	{
	}

	private void QuitToMainMenu()
	{
	}

	private void QuitToDesktop()
	{
	}

	public static MainMenuButton GetLoadButton()
	{
		return null;
	}
}
