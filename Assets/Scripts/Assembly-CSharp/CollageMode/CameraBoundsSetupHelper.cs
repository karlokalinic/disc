using System;
using UnityEngine;

namespace CollageMode
{
	public class CameraBoundsSetupHelper : MonoBehaviour
	{
		[SerializeField]
		private CollageCameraController cameraController;

		[HideInInspector]
		public SelectMapOperation selectedOperation;

		public static Action OnDataChanged;

		private string currentMapIdentifier;

		public bool UseBounds
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
