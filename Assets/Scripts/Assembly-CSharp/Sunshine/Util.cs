using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Sunshine
{
	public static class Util
	{
		public static System.Random random;

		public static T ParseEnum<T>(string value)
		{
			return default(T);
		}

		public static IEnumerable<T> GetValues<T>()
		{
			return null;
		}

		public static void AppendWithDelimiter(StringBuilder value, string appendix, string delimiter = ",")
		{
		}

		public static string WrapInColor(string input, string color)
		{
			return null;
		}

		public static void AddDistinctToDictionary<K, V>(K key, V value, IDictionary<K, List<V>> dictionary)
		{
		}

		public static Color ConvertColor(int r, int g, int b, int a)
		{
			return default(Color);
		}

		public static void SetRectPositionInScreenSpace(RectTransform rectTransform, Vector3 targetPosition)
		{
		}

		public static void SetRectPositionInFinalCameraSpace(RectTransform rectTransform, Vector3 targetPosition, float scale = 1f)
		{
		}

		public static string Capitalize(string value)
		{
			return null;
		}
	}
}
