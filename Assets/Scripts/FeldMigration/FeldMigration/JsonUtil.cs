using FullSerializer;

namespace FeldMigration
{
	public static class JsonUtil
	{
		private static readonly fsSerializer serializer;

		public static void SaveToFile(object obj, string directoryName, string fileName)
		{
		}

		public static string Serialize(object value)
		{
			return null;
		}

		public static T ReadFromFile<T>(string directoryName, string fileName)
		{
			return default(T);
		}

		public static T Deserialize<T>(string serializedState)
		{
			return default(T);
		}

		public static string EscapeKey(string s)
		{
			return null;
		}

		public static string EscapeValue(string s)
		{
			return null;
		}
	}
}
