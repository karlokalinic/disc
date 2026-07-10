using PixelCrushers.DialogueSystem;
using UnityEngine;
using Voidforge;

public class RedButtonSwitch : SingletonComponent<RedButtonSwitch>
{
	private CanvasDialogueUI uiComponent;

	public RectTransform RealButton;

	public RectTransform FakeButton;

	public RectTransform LedgerFakeButton;

	public bool IsAnyFakeButtonActive()
	{
		return false;
	}

	public void RunEnable()
	{
	}

	public void RunDisable()
	{
	}

	public static void WasClicked()
	{
	}

	public static void LedgerButtonWasClicked()
	{
	}

	public static void EnableFakeButton()
	{
	}

	public static void EnableLedgerFakeButton()
	{
	}

	public static void DisableFakeButton()
	{
	}

	public static void DisableLedgerFakeButton()
	{
	}
}
