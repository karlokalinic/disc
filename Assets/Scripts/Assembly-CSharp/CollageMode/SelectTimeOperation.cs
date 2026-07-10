using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class SelectTimeOperation : Operation
	{
		[SerializeField]
		private int hour;

		public int Hour => 0;

		private string baseDisplayName => null;

		public override string DisplayName => null;

		public override string Identifier => null;

		public override bool IsInUse()
		{
			return false;
		}

		public override void Execute()
		{
		}
	}
}
