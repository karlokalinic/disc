using Newtonsoft.Json;

namespace FeldMigration
{
	public class FeldVariablesGroupObject
	{
		public string type;

		public string aspect;

		public string name;

		[JsonProperty]
		public FeldVariablesSubgroupObject[] items;

		public FeldMeta meta;

		public FeldVariablesGroupObject(string name)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
