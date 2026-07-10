using UnityEngine;

public class LuaGameObjectsSwitcherNetWorth : LuaGameObjectsSwitcher
{
	[SerializeField]
	private StockValueController stockValueController;

	protected override void OnBooleanChanged(bool value)
	{
	}
}
