using System;
using System.Collections;
using System.Text;
using FullSerializer;

namespace Sunshine
{
	public static class JsonUtil
	{
		private static readonly fsSerializer serializer;

		public static IEnumerator SaveToFileCoR(object obj, string directoryName, string fileName, Action<bool> callback)
		{
			return null;
		}

		public static void SaveToFile(object obj, string directoryName, string fileName)
		{
		}

		public static string Serialize(object value)
		{
			return null;
		}

		public static void Serialize(object value, ref StringBuilder stringBuilder)
		{
		}

		public static IEnumerator ReadFromFileCoR<T>(string directoryName, string fileName, Action<T> callback)
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
