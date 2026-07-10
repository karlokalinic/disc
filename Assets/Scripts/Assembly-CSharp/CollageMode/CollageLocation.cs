using System;
using UnityEngine;

namespace CollageMode
{
	[Serializable]
	public class CollageLocation
	{
		[Serializable]
		public class Map
		{
			public string scenePath;

			public GameObject mapPrefab;

			public GameObject[] otherPrefabs;

			public float baseMapHeight;
		}

		[Serializable]
		public class Camera
		{
			public Vector2 minBounds;

			public Vector2 maxBounds;

			public Vector2 cameraStartPosition;
		}

		[Serializable]
		public class HiddenImages
		{
			public HiddenImageCreateData[] images;
		}

		public Map MapData;

		public Camera CameraData;

		public HiddenImages HiddenImagesData;

		public string OperationIdentifier;

		public SceneProperties SceneProperties;
	}
}
