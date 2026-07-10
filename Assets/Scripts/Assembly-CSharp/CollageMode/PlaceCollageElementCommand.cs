using System;
using UnityEngine;

namespace CollageMode
{
	public class PlaceCollageElementCommand : Command
	{
		private readonly Guid guid;

		private readonly Vector3 position;

		public PlaceCollageElementCommand(Guid guid, Vector3 position)
		{
		}

		public override void Execute(CollageMode collageMode)
		{
		}

		public override void Undo(CollageMode collageMode)
		{
		}

		public override void Dispose(CollageMode collageMode)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
