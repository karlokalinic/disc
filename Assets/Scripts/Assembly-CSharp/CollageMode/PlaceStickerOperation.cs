using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class PlaceStickerOperation : Operation
	{
		[SerializeField]
		private Sprite stickerSprite;

		[SerializeField]
		private float spriteScale;

		[SerializeField]
		protected string term;

		[SerializeField]
		protected string nameArgument;

		public override string DisplayTerm => null;

		public override string DisplayName => null;

		public Sprite StickerSprite => null;

		public float SpriteScale => 0f;

		public override string Identifier => null;

		public override void Execute()
		{
		}
	}
}
