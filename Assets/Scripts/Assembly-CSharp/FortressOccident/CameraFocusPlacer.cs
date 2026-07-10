using System.Collections.Generic;
using UnityEngine;
using Voidforge;

namespace FortressOccident
{
	[CreateAssetMenu]
	public class CameraFocusPlacer : SingletonScriptable<CameraFocusPlacer>
	{
		public List<CameraFocusData> cameraFocusDataList;

		public void AddCurrentCameraPositionToList(string name)
		{
		}

		public void InsertCameraPositionsToWorld()
		{
		}

		public void ClearCameraPositionsFromList()
		{
		}

		public void ClearSpecificPositionFromList(int index)
		{
		}
	}
}
