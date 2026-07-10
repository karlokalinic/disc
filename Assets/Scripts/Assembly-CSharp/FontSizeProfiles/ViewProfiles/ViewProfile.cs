using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public abstract class ViewProfile
	{
		public string ViewName;

		public abstract Dictionary<string, ElementSettings> GetAllTextElements();
	}
}
