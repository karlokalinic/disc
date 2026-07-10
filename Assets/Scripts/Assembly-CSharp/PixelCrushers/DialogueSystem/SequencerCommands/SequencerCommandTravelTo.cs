using System.Collections;
using System.Collections.Generic;
using FortressOccident;
using UnityEngine;
using UnityEngine.AI;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandTravelTo : SequencerCommand
	{
		private Transform subject;

		private Transform destination;

		private bool toggleAgent;

		private NavMeshAgent agent;

		private int running;

		private bool dontWaitContinue;

		private Vector3 defLocation;

		private Character subjectChar;

		private Animator anim;

		private float heading;

		private static readonly int generic;

		private static readonly int toGenericTrigger;

		private static Dictionary<string, int> movementCommands;

		private const float STUCKFIX_TIME_TO_ACTIVATE = 2f;

		private float stuckFix_distanceLeft;

		private float stuckFix_adjustStateTimer;

		private bool stuckFix_eventTriggered;

		private bool isNPC => false;

		public void Start()
		{
		}

		private void Update()
		{
		}

		private void CheckForCharacterStuckAndApplyFixIfNeeded()
		{
		}

		private bool ValidateSubject()
		{
			return false;
		}

		private IEnumerator CharacterMovement()
		{
			return null;
		}

		private void MoveToDestination()
		{
		}

		private void OnCharacterArrival(Character c, bool wasDestinationReached)
		{
		}
	}
}
