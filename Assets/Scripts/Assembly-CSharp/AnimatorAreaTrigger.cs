using UnityEngine;

public class AnimatorAreaTrigger : MonoBehaviour
{
	[SerializeField]
	public float radius;

	[SerializeField]
	public GameObject character;

	[SerializeField]
	public string triggerOnEnter;

	[SerializeField]
	public string triggerOnLeave;

	[SerializeField]
	public float collisionCheckFrequency;

	private Animator animator;

	private bool inside;

	private void OnEnable()
	{
	}

	private void CheckForCollision()
	{
	}
}
