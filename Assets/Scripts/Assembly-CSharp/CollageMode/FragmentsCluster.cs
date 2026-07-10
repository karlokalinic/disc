using System;
using System.Collections.Generic;
using UnityEngine;

namespace CollageMode
{
	[Serializable]
	public class FragmentsCluster
	{
		private Dictionary<string, int> fragments;

		public Vector3 Position { get; private set; }

		public bool IsCompleted => false;

		public FragmentsCluster(Fragment fragment, Vector3 position)
		{
		}

		public void AddFragment(Fragment fragment)
		{
		}

		public void RemoveFragment(Fragment fragment)
		{
		}
	}
}
