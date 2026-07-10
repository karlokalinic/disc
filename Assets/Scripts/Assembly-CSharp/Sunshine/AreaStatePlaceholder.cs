using System.Collections.Generic;
using UnityEngine;

namespace Sunshine
{
	public class AreaStatePlaceholder : MonoBehaviour
	{
		private static Dictionary<string, Location> locations;

		private static bool initDone;

		private static AreaStatePlaceholder instance;

		public static void Initialize()
		{
		}

		public void Awake()
		{
		}

		public static void Register(StateSwitcher state)
		{
		}

		public static void Unregister(StateSwitcher state)
		{
		}

		public static void SwitchTo(string areaName, string statename)
		{
		}

		public static void InitializeAreas()
		{
		}

		public static void LoadFromLua()
		{
		}

		public static Location GetLocation(string areaName)
		{
			return null;
		}

		private void TestCrashPinball()
		{
		}

		private void TestInitialPinball()
		{
		}

		private void TestLuaLoad()
		{
		}
	}
}
