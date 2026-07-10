using UnityEngine;

public class AnimationDisableLayerOnExit : StateMachineBehaviour
{
	private bool _checkedOnce;

	private AnimDice _animDice;

	[SerializeField]
	private float duration;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}
