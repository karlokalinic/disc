using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandSpecialAnimation : SequencerCommand
	{
		private Transform subject;

		private string _animation;

		private Transform entity;

		private float waitFor;

		public void Start()
		{
		}

		private IEnumerator MonitorState(Animator animator, string stateName)
		{
			return null;
		}

		private IEnumerator WaitForRightMoment()
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
