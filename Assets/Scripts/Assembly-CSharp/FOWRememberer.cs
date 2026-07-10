using System.Collections.Generic;
using UnityEngine;
using Voidforge;

public class FOWRememberer : SingletonComponent<FOWRememberer>
{
	private Dictionary<string, Color[]> fows;

	protected override void Awake()
	{
	}

	public static void SaveFOW(string str, Color[] colors)
	{
	}

	public static bool LoadFOW(string str, ref Color[] colors)
	{
		return false;
	}

	public static void Reset()
	{
	}

	public static Dictionary<string, Color[]> GetFOWsForSaving()
	{
		return null;
	}

	public static void LoadFOWsAfterLoad(Dictionary<string, Color[]> fowData)
	{
	}
}
