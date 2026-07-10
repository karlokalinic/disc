using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class OperationsSetComposite : BaseOperationsSet
	{
		[SerializeField]
		private OperationsSet[] operationsSets;

		private Operation[] combinedOperations;

		public override Operation[] Operations => null;

		public override void Initialize()
		{
		}
	}
}
