using System;
using UnityEngine;

namespace CollageMode
{
	public class MoveCollageElementCommand : Command
	{
		private readonly Guid guid;

		private readonly Vector3 previousPosition;

		private readonly Vector3 newPosition;

		public MoveCollageElementCommand(Guid guid, Vector3 previousPosition, Vector3 newPosition)
		{
		}

		public override void Execute(CollageMode collageMode)
		{
		}

		public override void Undo(CollageMode collageMode)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
