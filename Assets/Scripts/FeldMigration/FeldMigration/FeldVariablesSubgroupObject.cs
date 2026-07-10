using System.Collections.Generic;
using Newtonsoft.Json;

namespace FeldMigration
{
	public class FeldVariablesSubgroupObject
	{
		public string type;

		public string aspect;

		public string name;

		[JsonProperty]
		public List<GraphData> items;

		public FeldVariablesSubgroupObject(string name)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
