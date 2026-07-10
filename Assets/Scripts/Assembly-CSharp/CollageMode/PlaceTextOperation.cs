using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class PlaceTextOperation : Operation
	{
		[SerializeField]
		private Color backgroundColor;

		[SerializeField]
		private Sprite backgroundSprite;

		[SerializeField]
		private string font;

		[SerializeField]
		private int fontSize;

		[SerializeField]
		private CollageText.Padding textPadding;

		public override string DebugName => null;

		public override string Identifier => null;

		public Color BackgroundColor => default(Color);

		public Sprite BackgroundSprite => null;

		public string Font => null;

		public int FontSize => 0;

		public CollageText.Padding TextPadding => default(CollageText.Padding);

		public override void Execute()
		{
		}
	}
}
