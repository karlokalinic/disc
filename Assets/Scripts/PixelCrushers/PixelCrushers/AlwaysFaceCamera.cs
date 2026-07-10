using UnityEngine;

namespace PixelCrushers
{
	public class AlwaysFaceCamera : MonoBehaviour
	{
		[SerializeField]
		private bool m_yAxisOnly;

		[SerializeField]
		private bool m_rotate180;

		private Camera m_mainCamera;

		public bool yAxisOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool rotate180
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Update()
		{
		}
	}
}
