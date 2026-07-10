using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class SelectFilterOperation : Operation
	{
		private const string TERM_PREFIX = "FILTER/";

		[SerializeField]
		private string filterName;

		[SerializeField]
		private float intensity;

		[SerializeField]
		private string displayTerm;

		public override string DisplayTerm => null;

		public override string Identifier => null;

		public float Intensity => 0f;

		public override bool IsInUse()
		{
			return false;
		}

		public override void Execute()
		{
		}

		public override void Preview()
		{
		}
	}
}
