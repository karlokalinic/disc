using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class OperationsSet : BaseOperationsSet
	{
		[SerializeField]
		private Operation[] operations;

		private bool isInitialized;

		public override Operation[] Operations => null;

		public override void Initialize()
		{
		}
	}
}
