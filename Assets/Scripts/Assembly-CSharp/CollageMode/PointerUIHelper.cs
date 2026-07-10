using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace CollageMode
{
	public static class PointerUIHelper
	{
		private const int UILayer = 5;

		private const int MouseRaycastLayer = 8;

		private static bool isInitialized;

		private static PointerEventData pointerEventData;

		private static List<RaycastResult> eventSystemRaysastResults;

		public static bool IsPointerOverUI()
		{
			return false;
		}

		public static bool IsPointerOverUIOrCollageElement()
		{
			return false;
		}

		private static bool IsPointerOverLayer(int layerMask)
		{
			return false;
		}
	}
}
