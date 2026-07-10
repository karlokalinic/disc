using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	public class ResourceLocationMap : IResourceLocator
	{
		public string LocatorId { get; private set; }

		public Dictionary<object, IList<IResourceLocation>> Locations { get; private set; }

		public IEnumerable<object> Keys => null;

		public ResourceLocationMap(string id, int capacity = 0)
		{
		}

		public ResourceLocationMap(string id, IList<ResourceLocationData> locations)
		{
		}

		public bool Locate(object key, Type type, out IList<IResourceLocation> locations)
		{
			locations = null;
			return false;
		}

		public void Add(object key, IResourceLocation location)
		{
		}

		public void Add(object key, IList<IResourceLocation> locations)
		{
		}
	}
}
