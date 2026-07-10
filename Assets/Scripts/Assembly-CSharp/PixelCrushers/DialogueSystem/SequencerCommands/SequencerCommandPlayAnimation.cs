using System.Collections;
using FortressOccident;
using UnityEngine;
using UnityEngine.AI;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandPlayAnimation : SequencerCommand
	{
		private Transform subject;

		private string _animation;

		private BasicEntity entity;

		private bool lockRotation;

		private bool unlockRotationSpeed;

		private NavMeshAgent navAgent;

		private float previousAngularSpeed;

		private AnimatorClipInfo playedAnimatorclip;

		private float previousNormalizedTime;

		public void Start()
		{
		}

		private IEnumerator MonitorState(Animator animator)
		{
			return null;
		}

		private bool CheckIsInState(Animator animator, int stateName, out AnimatorStateInfo animatorStateInfo)
		{
			animatorStateInfo = default(AnimatorStateInfo);
			return false;
		}

		private bool CheckIsAnimationStuck(Animator animator)
		{
			return false;
		}
	}
}
