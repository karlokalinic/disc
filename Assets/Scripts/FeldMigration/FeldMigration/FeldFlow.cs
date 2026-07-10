namespace FeldMigration
{
	public class FeldFlow
	{
		public string id;

		public string flow;

		public string label;

		public string[] children;

		public FeldMeta meta;

		public GraphData data;

		public string type;

		public bool badge;

		public string badge_color;

		public string claim_description;

		public string name;

		public FeldFlow(string id, string flow)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
