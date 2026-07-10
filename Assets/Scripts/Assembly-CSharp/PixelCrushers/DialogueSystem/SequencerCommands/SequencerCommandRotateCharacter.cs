using UnityEngine;
using UnityEngine.AI;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandRotateCharacter : SequencerCommand
	{
		private Transform subject;

		private float rotation_x;

		private float rotation_y;

		private float rotation_z;

		private bool relative;

		private Transform reference;

		private NavMeshAgent agent;

		public void Start()
		{
		}
	}
}
