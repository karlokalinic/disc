using System;
using UnityEngine;

namespace CollageMode
{
	public class ChangeTextBorderColorCommand : Command
	{
		private readonly Guid guid;

		private readonly Color previousColor;

		private readonly Color newColor;

		public ChangeTextBorderColorCommand(Guid guid, Color previousColor, Color newColor)
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
