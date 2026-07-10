using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class ChangeTextFontSizeOperation : Operation
	{
		[SerializeField]
		private string displayName;

		[SerializeField]
		private float fontSize;

		public override string DisplayTerm => null;

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
