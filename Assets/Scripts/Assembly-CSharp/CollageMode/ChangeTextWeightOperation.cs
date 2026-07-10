using TMPro;
using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class ChangeTextWeightOperation : Operation
	{
		[SerializeField]
		private string displayName;

		[SerializeField]
		private FontWeight fontWeight;

		public override string DisplayTerm => null;

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
