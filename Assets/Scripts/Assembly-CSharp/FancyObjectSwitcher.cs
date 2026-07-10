using System.Collections.Generic;
using UnityEngine;

public class FancyObjectSwitcher : MonoBehaviour
{
	public string option;

	public int value;

	public OptionLogic logic;

	private static List<FancyObjectSwitcher> registry;

	public void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public void Refresh()
	{
	}

	public static void RefreshAll()
	{
	}

	public void Switch(int menuValue)
	{
	}

	public bool Check(int menuValue)
	{
		return false;
	}
}
