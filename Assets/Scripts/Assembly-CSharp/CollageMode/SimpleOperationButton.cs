using UnityEngine;

namespace CollageMode
{
	public class SimpleOperationButton : OperationButton
	{
		[SerializeField]
		private Operation operation;

		protected override void Awake()
		{
		}
	}
}
