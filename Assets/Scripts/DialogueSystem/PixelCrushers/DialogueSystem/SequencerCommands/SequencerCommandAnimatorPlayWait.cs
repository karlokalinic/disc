using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandAnimatorPlayWait : SequencerCommand
	{
		private const float maxDurationToWaitForStateStart = 1f;

		public void Start()
		{
		}

		private IEnumerator MonitorState(Animator animator, string stateName)
		{
			return null;
		}

		private bool CheckIsInState(Animator animator, string stateName, out AnimatorStateInfo animatorStateInfo)
		{
			animatorStateInfo = default(AnimatorStateInfo);
			return false;
		}
	}
}
