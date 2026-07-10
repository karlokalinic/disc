using System.Collections.Generic;
using UnityEngine;

namespace Sunshine
{
	public class PositionStateLocation : MonoBehaviour
	{
		public static Dictionary<string, List<StateTransformPair>> positionRegistry;

		public string areaName;

		public string[] activeStates;

		private Location location;

		public void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public static List<StateTransformPair> GetLocationPairs(string areaName, string stateName)
		{
			return null;
		}
	}
}
