using UnityEngine;

public class TabSwitcher : MonoBehaviour
{
	public static TabSwitcher CURRENT;

	private int activeTabIndex;

	public RectTransform[] tabPanels;

	public ToggleButton[] tabButtons;

	private const string TAB_VALUE = "Tab_Value";

	private void Start()
	{
	}

	private void TabLoad()
	{
	}

	public void SwitchTab(int index)
	{
	}

	private void Activate(int index)
	{
	}

	private void Deactivate(int index)
	{
	}

	public void FunctionTabSave()
	{
	}
}
