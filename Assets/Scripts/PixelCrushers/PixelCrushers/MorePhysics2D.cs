using UnityEngine;

namespace PixelCrushers
{
	public static class MorePhysics2D
	{
		public static bool queriesStartInColliders
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int maxRaycastResults
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static GameObject Raycast2DWithoutSelf(Transform source, Transform destination, LayerMask layerMask)
		{
			return null;
		}

		public static void LogUsePhysics2DWarning()
		{
		}
	}
}
