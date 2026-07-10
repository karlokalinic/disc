using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class ChangePoseOperation : Operation
	{
		[SerializeField]
		private AnimationClip pose;

		[SerializeField]
		private bool excludeForMinors;

		public AnimationClip Pose => null;

		public override string Identifier => null;

		public override bool CanBeShown => false;

		public override void Execute()
		{
		}

		public override void Preview()
		{
		}

		public override bool IsInUse()
		{
			return false;
		}
	}
}
