using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class ChangeTextFontOperation : Operation
	{
		[SerializeField]
		private string font;

		public override string DebugName => null;

		public override string Identifier => null;

		public override void Execute()
		{
		}

		public override bool IsInUse()
		{
			return false;
		}

		public static string GetUsableFont(string targetFont)
		{
			return null;
		}
	}
}
