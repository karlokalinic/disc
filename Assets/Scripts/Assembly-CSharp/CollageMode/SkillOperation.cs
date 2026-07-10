using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class SkillOperation : Operation
	{
		private const string ACTORS_TERM_PREFIX = "Actors/";

		[SerializeField]
		private string characterNameTerm;

		public override string AutofillString => null;

		public override Color AutofillColor => default(Color);

		public override string Identifier => null;

		public override void Execute()
		{
		}
	}
}
