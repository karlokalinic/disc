using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class SelectMapOperation : Operation
	{
		private const string TERM_PREFIX = "MAP/";

		[SerializeField]
		private string term;

		[SerializeField]
		private CollageLocation.Map map;

		[SerializeField]
		private CollageLocation.HiddenImages hiddenImagesOnMap;

		[SerializeField]
		private CollageLocation.Camera camera;

		[SerializeField]
		private SceneProperties sceneProperties;

		public override string DisplayTerm => null;

		public override string Identifier => null;

		public CollageLocation.Map Map => null;

		public CollageLocation.HiddenImages HiddenImages => null;

		public CollageLocation.Camera Camera => null;

		public CollageLocation Data => null;

		public override bool IsInUse()
		{
			return false;
		}

		public override void Execute()
		{
		}

		public void SilentExecute(CollageMode context)
		{
		}
	}
}
