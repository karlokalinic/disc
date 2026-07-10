using UnityEngine;

namespace CollageMode
{
	public class HiddenImageAssembler : MonoBehaviour
	{
		[SerializeField]
		private FullScreenImage fullScreenImage;

		public bool AreFragmentsConnected()
		{
			return false;
		}

		private void RunCompleteAnimation(HiddenImageCompleteData fullCluster, Vector3 position)
		{
		}
	}
}
