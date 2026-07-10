using UnityEngine;

namespace CollageMode
{
	public class CollageCameraController : MonoBehaviour, ISerializableManager
	{
		public class CameraData : SerializableData
		{
			public Vector2 Position;

			public float Zoom;
		}

		[SerializeField]
		private float panSpeed;

		[SerializeField]
		private float panAcceleration;

		public bool boundMovement;

		private CollageLocation.Camera cameraData;

		private Camera camera;

		private Transform cameraTransform;

		private Vector2 previousMovement;

		private Vector2 lastMousePosition;

		private bool isDragging;

		public string SerializedCategoryName => null;

		private void Awake()
		{
		}

		public void SetUpCamera(CollageLocation.Camera data)
		{
		}

		public void GetCameraBounds(out Vector2 minBounds, out Vector2 maxBounds)
		{
			minBounds = default(Vector2);
			maxBounds = default(Vector2);
		}

		public Vector2 GetCameraPosition()
		{
			return default(Vector2);
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		private Vector2 GetWASDMovement()
		{
			return default(Vector2);
		}

		private Vector2 GetMouseMovement()
		{
			return default(Vector2);
		}

		private Vector2 LimitCameraMovement(Vector2 movement)
		{
			return default(Vector2);
		}

		private void Init()
		{
		}

		public SerializableData Save()
		{
			return null;
		}

		public void Load(SerializableData data)
		{
		}
	}
}
