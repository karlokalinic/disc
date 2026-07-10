using Newtonsoft.Json;

namespace FeldMigration
{
	public class FeldObject
	{
		public string type;

		public string aspect;

		public string name;

		public bool permanent;

		public object[] items;

		[JsonIgnore]
		public FeldMeta meta;

		public FeldObject(string aspect, string name)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
