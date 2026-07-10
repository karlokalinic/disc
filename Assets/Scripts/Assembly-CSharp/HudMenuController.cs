public class HudMenuController : HudElementController
{
	public HudMenuButton charsheet;

	public HudMenuButton inventory;

	public HudMenuButton journal;

	public HudMenuButton thoughtcabinet;

	private static HudMenuButton _selectedView;

	public static HudMenuController Current { get; private set; }

	public static void SelectView(HudMenuButton selectedView)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnWorldStarted()
	{
	}

	private void OnInventoryChange()
	{
	}

	public void changeHudMenuButtons(HudButtonState inv, HudButtonState thc, HudButtonState chr, HudButtonState jrn)
	{
	}

	public void changeCharsheetButton(HudButtonState state)
	{
	}

	public void changeInventoryButton(HudButtonState state)
	{
	}

	public void changeJournalButton(HudButtonState state)
	{
	}

	public void changeThoughtCabinetButton(HudButtonState state)
	{
	}

	private void ChangeButton(HudMenuButton button, HudButtonState state)
	{
	}

	public void ResetFreshButtons()
	{
	}

	public void RefreshButtons()
	{
	}
}
