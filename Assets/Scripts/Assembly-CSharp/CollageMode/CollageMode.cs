using UnityEngine;

namespace CollageMode
{
	public class CollageMode : MonoBehaviour
	{
		[SerializeField]
		private CollageElementsContainer collageElements;

		[SerializeField]
		private MapManager mapManager;

		[SerializeField]
		private CollageCameraController cameraController;

		[SerializeField]
		private FilterManager filterManager;

		[SerializeField]
		private TimeManager timeManager;

		[SerializeField]
		private WeatherManager weatherManager;

		[SerializeField]
		private CollageDialogue dialogue;

		[SerializeField]
		private Frame frame;

		[SerializeField]
		private SelectMapOperation defaultMap;

		[SerializeField]
		private SelectTimeOperation defaultTime;

		[SerializeField]
		private SelectFilterOperation defaultFilter;

		public CollageElementsContainer CollageElements => null;

		public MapManager MapManager => null;

		public CollageCameraController CameraController => null;

		public FilterManager FilterManager => null;

		public TimeManager TimeManager => null;

		public WeatherManager WeatherManager => null;

		public CollageDialogue Dialogue => null;

		public Frame Frame => null;

		private void Start()
		{
		}

		public void Clear(bool placeDefaultHarry)
		{
		}

		private void LoadDefaultMap()
		{
		}

		private void PlaceDefaultHarry()
		{
		}
	}
}
