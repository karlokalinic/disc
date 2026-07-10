using UnityEngine;

namespace CollageMode
{
	public class CollageElementOptimizer : MonoBehaviour
	{
		[SerializeField]
		private int instanceCount;

		[SerializeField]
		private GameObject[] disableWhenMultipleInstances;

		private CollageElement collageElement;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void HandleDisablingObjects()
		{
		}
	}
}
