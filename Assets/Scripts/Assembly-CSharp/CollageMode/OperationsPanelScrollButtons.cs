using UnityEngine;

namespace CollageMode
{
	public class OperationsPanelScrollButtons : MonoBehaviour
	{
		[field: SerializeField]
		public ExtendedButton ScrollBeginningButton { get; private set; }

		[field: SerializeField]
		public ExtendedButton ScrollPreviousButton { get; private set; }

		[field: SerializeField]
		public ExtendedButton ScrollNextButton { get; private set; }

		[field: SerializeField]
		public ExtendedButton ScrollEndButton { get; private set; }

		private void OnEnable()
		{
		}
	}
}
