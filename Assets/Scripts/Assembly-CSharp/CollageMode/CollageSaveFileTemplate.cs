using System;
using Newtonsoft.Json;
using UnityEngine;

namespace CollageMode
{
	[Serializable]
	public class CollageSaveFileTemplate
	{
		public Vector2 screenshotResolution;

		public CollageSerializer.CollageData collageJSON;

		public static JsonSerializerSettings Settings => null;

		public static CollageSaveFileTemplate LoadFromBytes(byte[] bytes)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
