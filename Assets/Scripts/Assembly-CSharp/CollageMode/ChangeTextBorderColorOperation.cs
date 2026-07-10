using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class ChangeTextBorderColorOperation : Operation
	{
		public override string DebugName => null;

		public override string Identifier => null;

		public override void Execute()
		{
		}

		public override bool IsInUse()
		{
			return false;
		}
	}
}
