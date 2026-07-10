using System.Collections;
using FortressOccident;
using UnityEngine;
using UnityEngine.AI;

public class NPCWalkAI : MonoBehaviour
{
	public Transform NPC;

	public bool randomize;

	public Transform[] waypoints;

	public Transform[] goals;

	public float delayTimeSec;

	protected int destPoint;

	protected int goalsLength;

	protected int goalsIndex;

	protected int timer;

	protected int delay;

	protected float delays;

	protected NavMeshAgent agent;

	protected Animator anim;

	protected AnimatorStateInfo animatorInfo;

	protected AnimatorTransitionInfo animatorTransition;

	protected float _frequency;

	protected float _range;

	protected Transform subject;

	public Character subjectChar;

	protected float Heading;

	private int canTrigger;

	private bool canLock;

	private int canTimer;

	private int canDelay;

	private void Awake()
	{
	}

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	public void StartWatch()
	{
	}

	public void StopWatch()
	{
	}

	protected IEnumerator Watch()
	{
		return null;
	}

	private void AnimationAI()
	{
	}
}
