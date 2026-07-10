using UnityEngine;
using UnityEngine.AI;
using Voidforge;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandMoveCharacter : SequencerCommand
	{
		private Transform subject;

		private float destination_x;

		private float destination_y;

		private float destination_z;

		private Transform reference;

		private NavMeshAgent agent;

		public ComponentRef<NavMeshAgent> navAgent { get; protected set; }

		public void Start()
		{
		}
	}
}
