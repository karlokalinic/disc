using FortressOccident;
using UnityEngine;
using UnityEngine.UI;

public class WritersPanel : FOComponent
{
	public static bool IsWritersToolOpened;

	public RectTransform booleanContent;

	public static Color truthGreen;

	public static Color truthLightGreen;

	public static Color falseOrange;

	public static Color falseLightOrange;

	private int characterHiderIndex;

	public ToggleButton winButton;

	public ToggleButton loseButton;

	public ToggleButton teleportButton;

	public Selectable fistSelected;

	private Selectable lastSelectedObject;

	public bool IsActive => false;

	private void Start()
	{
	}

	public void Hide()
	{
	}

	public void Show()
	{
	}

	private void ResetWritersPanel()
	{
	}

	public void Toggle()
	{
	}

	public void UpdateBooleans(Transform searchable)
	{
	}

	public void ConversionStart()
	{
	}

	public void ConversionEnd()
	{
	}

	public void WinNextRoll()
	{
	}

	public void LoseNextRoll()
	{
	}

	public void ToggleTeleportMode()
	{
	}

	public void ToggleSound()
	{
	}

	private void ShowHideCharacter()
	{
	}

	private void ToggleInteriorFoW()
	{
	}

	private void PutClothesOnTequila()
	{
	}

	private void ReleaseCameraLimits()
	{
	}

	public void ShowLobby()
	{
	}
}
