using UnityEngine;

namespace CollageMode
{
	public class SelectMapCommand : Command
	{
		private CollageLocation previousData;

		private readonly CollageLocation newData;

		private Vector2 cameraPositionDifference;

		private float heightDifference;

		private Vector3 ElementsPositionOffset => default(Vector3);

		public SelectMapCommand(CollageLocation data)
		{
		}

		public override void Execute(CollageMode collageMode)
		{
		}

		public override void Undo(CollageMode collageMode)
		{
		}

		public override bool Validate(CollageMode collageMode)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
