using System.Collections.Generic;
using Sunshine;

public static class ContainerSourcePersister
{
	public class ContainerSourceState
	{
		public Dictionary<string, ContainerItem[]> itemRegistry;
	}

	public static ContainerSourceState Serialize()
	{
		return null;
	}

	public static void Deserialize(ContainerSourceState containerSourceState)
	{
	}
}
