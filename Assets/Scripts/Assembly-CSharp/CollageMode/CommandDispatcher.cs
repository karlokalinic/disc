using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CollageMode
{
	public class CommandDispatcher : MonoBehaviour
	{
		private int lastCommandIndex;

		private List<Command> executedCommands;

		private Command previewedCommand;

		public bool CanUndo => false;

		public bool CanRedo => false;

		public event Action OnUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Execute(Command command)
		{
		}

		public void Undo()
		{
		}

		public void Redo()
		{
		}

		public void Clear(bool placeDefaultHarry = true)
		{
		}

		public void Preview(Command command)
		{
		}

		public void ClearPreview()
		{
		}

		private void DisposePreview()
		{
		}
	}
}
