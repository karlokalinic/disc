using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public class MechanimStateSounds : StateMachineBehaviour
	{
		public bool SoundFollowsObject;

		[SoundGroup]
		public string enterSoundGroup;

		[SoundGroup]
		public string exitSoundGroup;

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}
	}
}
