using Newtonsoft.Json;

namespace FeldMigration
{
	public class GeoData
	{
		public float? x;

		public float? y;

		[JsonIgnore]
		public float? w;

		[JsonIgnore]
		public float? h;

		public GeoData()
		{
		}

		public GeoData(float x, float y)
		{
		}

		public GeoData(float x, float y, float w, float h)
		{
		}
	}
}
