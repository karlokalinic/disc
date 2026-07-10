using System.Collections.Generic;
using Sunshine.Metric;

public static class ThoughtCabinetProjectPersister
{
	public class THCPState
	{
		public string name;

		public bool isFresh;

		public ThoughtState state;

		public int timeLeft;
	}

	public static List<THCPState> SerializeProperties()
	{
		return null;
	}

	public static void DeserializeProperties(List<THCPState> stateList)
	{
	}
}
