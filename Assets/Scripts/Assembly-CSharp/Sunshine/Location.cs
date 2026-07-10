using System;
using System.Collections.Generic;

namespace Sunshine
{
	public class Location : IComparable
	{
		public string name;

		public string[] validStates;

		public int defaultState;

		public int currentState;

		public List<StateSwitcher> stateSwitchers;

		public Location(string name, string[] validStates, int defaultState = 0)
		{
		}

		public int StateIndex(string stateName)
		{
			return 0;
		}

		public bool HasState(string stateName)
		{
			return false;
		}

		public void RefreshState(StateSwitcher switcher)
		{
		}

		public void SwitchTo(string stateName)
		{
		}

		private void VisualUpdate(string stateName)
		{
		}

		public void Reset()
		{
		}

		public void LoadFromLua()
		{
		}

		public int CompareTo(object obj)
		{
			return 0;
		}
	}
}
