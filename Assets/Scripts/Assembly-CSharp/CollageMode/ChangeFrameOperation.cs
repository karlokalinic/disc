using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class ChangeFrameOperation : Operation
	{
		private const string TermPrefix = "FRAME/";

		[SerializeField]
		private Sprite frameSprite;

		[SerializeField]
		private string term;

		public Sprite FrameSprite => null;

		public override string Identifier => null;

		public override string DisplayTerm => null;

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
