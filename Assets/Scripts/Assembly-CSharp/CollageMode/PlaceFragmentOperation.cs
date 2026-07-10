using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class PlaceFragmentOperation : Operation
	{
		[SerializeField]
		private HiddenImageCreateData hiddenImageData;

		[SerializeField]
		private float spriteScale;

		[SerializeField]
		private string term;

		[Space]
		[SerializeField]
		private HiddenImageCreateData[] fragmentsToSnapTo;

		[SerializeField]
		private Vector2 snapCenterOffset;

		public override bool CanBeShown => false;

		public HiddenImageCreateData HiddenImageData => null;

		public float SpriteScale => 0f;

		public HiddenImageCreateData[] FragmentsToSnapTo => null;

		public Vector2 SnapCenterOffset => default(Vector2);

		public override string Identifier => null;

		public override string DisplayTerm => null;

		private void OnValidate()
		{
		}

		public override void Execute()
		{
		}
	}
}
