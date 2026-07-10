using InControl;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsIconsController : MonoBehaviour
{
	public enum ButtonPorpose
	{
		undefined = -1,
		healing = 0,
		volition = 1,
		tabLeftChr = 2,
		tabRightChr = 3,
		leftSelectionHudPanel = 4,
		RighSelectionHudPanel = 5,
		radialSelection = 6,
		containerTakeAll = 7,
		containerExit = 8,
		charsheetLevelUp = 9,
		charsheetResetPoints = 10,
		thcActionBtn = 11,
		journalactivedone = 12,
		tabLeftInv = 13,
		tabRightInv = 14,
		tabLeftThc = 15,
		tabRightThc = 16,
		tabLeftJrn = 17,
		tabRightJrn = 18,
		dpadLeftInv = 19,
		dpadRightThc = 20,
		dpadUpJrn = 21,
		dpadDownChs = 22,
		leftHand = 23,
		rightHand = 24,
		sortThc = 25,
		journalRead = 26,
		invInteract = 27,
		invRead = 28,
		talkParty = 29,
		charsheetRead = 30,
		setsignatureButton = 31,
		worldInteract = 32,
		headOrbsInteract = 33,
		thcRead = 34,
		charsheetStartGame = 35,
		loadGameUI = 36,
		saveGameUI = 37,
		deleteSave = 38,
		kimTalkBkg = 39,
		kimTalk = 40,
		enlarge = 41,
		shrink = 42,
		Continue = 43,
		newspaperEndgame = 44,
		acceptChangesAndClose = 45,
		quicktravel = 46,
		back = 47,
		charsheetStatsRandom = 48,
		charsheetStatsRevert = 49,
		optionsResetSettings = 50,
		quickLoadGame = 51,
		quickSaveGame = 52,
		equipItemUI = 53,
		scrollTextOnAnalog = 54,
		collageProgressiveButton = 55,
		collageDestructiveButton = 56,
		collageEditButton = 57,
		collageToggleButton = 58,
		collagePreviousTab = 59,
		collageNextTab = 60,
		collageUndo = 61,
		collageRedo = 62,
		collageClear = 63,
		collageTakeScreenshot = 64,
		collagePreviousDrawerTool = 65,
		collageNextDrawerTool = 66,
		collagePreviousOperation = 67,
		collageNextOperation = 68,
		collageMove = 69,
		collageRotate = 70,
		collageScaleUp = 71,
		collageScaleDown = 72,
		collageDialogueToggleContinueType = 73,
		collageDialogueToggleCheckType = 74,
		collageSelect = 75
	}

	[SerializeField]
	private bool disableGameObject;

	[SerializeField]
	private Image optionalRTLimage;

	public ButtonPorpose thisButtonPorpose;

	public Image image;

	public Image OptionalRTL => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Reset()
	{
	}

	private void SetImageEnabled(bool enabled)
	{
	}

	public void UpdateButtonVisibility(CrossPlatformInputManager.ButtonsState state)
	{
	}

	private void OnChangeLanguage()
	{
	}

	private void LoadCorrectIcons(CrossPlatformInputManager.ButtonsState state)
	{
	}

	private string GetButtonIconNameFromPlayerAction(bool isPC, CrossPlatformInputManager.ButtonsState state, string iconName, PlayerAction playerAction)
	{
		return null;
	}

	private string GetIconNameFromDevice(Key key)
	{
		return null;
	}

	private string GetIconNameFromDevice(Mouse mouseKey)
	{
		return null;
	}

	private string GetIconNameFromDevice(InputControlType control, CrossPlatformInputManager.ButtonsState state)
	{
		return null;
	}

	private bool ShowOnlyOnMenus()
	{
		return false;
	}
}
