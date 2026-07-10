using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class PlaceCharacterOperation : Operation
	{
		private const string ACTORS_TERM_PREFIX = "Actors/";

		[SerializeField]
		private CollageCharacter characterPrefab;

		[SerializeField]
		private string placementSpecificTerm;

		public CollageCharacter CharacterPrefab => null;

		public override string DisplayTerm => null;

		public override string AutofillString => null;

		public override string Identifier => null;

		public override Color AutofillColor => default(Color);

		public override void Execute()
		{
		}
	}
}
