namespace FeldMigration
{
	public class FeldCard
	{
		public string id;

		public string type;

		public string flow;

		public string @base;

		public string card_type;

		public GeoData geo;

		public bool? permanent;

		public string[] entities;

		public string icon;

		public string color;

		public string pin_color;

		public HookData[] hooks;

		public string[] keywords;

		public FeldMeta meta;

		public GraphData data;

		public PinData[] inputs;

		public PinData[] outputs;

		public EdgeData[] edges;

		public string title;

		public string label;

		public string[] mixins;

		public DisplayData display;

		public FeldCard(string id, string type, string flow, string @base, string cardType, GeoData geoData)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
