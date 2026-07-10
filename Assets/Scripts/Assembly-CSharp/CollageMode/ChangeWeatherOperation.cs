using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class ChangeWeatherOperation : Operation
	{
		private const string TermPrefix = "WEATHER/";

		[SerializeField]
		private string weatherPresetName;

		[SerializeField]
		private string term;

		public override string Identifier => null;

		public override string DisplayTerm => null;

		public override void Execute()
		{
		}

		public override bool IsInUse()
		{
			return false;
		}
	}
}
