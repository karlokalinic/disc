using UnityEngine;
using UnityEngine.AI;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandCutsceneState : SequencerCommand
	{
		private string act;

		private GameObject tequila;

		private GameObject kim;

		private GameObject lena;

		private GameObject garte;

		private NavMeshAgent garteAgent;

		private NavMeshAgent tequilaAgent;

		private NavMeshAgent kimAgent;

		private Animator kimAnim;

		private Animator garteAnim;

		private Transform teqT;

		private Transform kimT;

		private Transform garteT;

		private Transform lenaT;

		private static readonly int squatInsta;

		private static readonly int generic;

		private static readonly int toGenericTrigger;

		public void Start()
		{
		}

		private void FlipOffRecover()
		{
		}

		private void FlipOffAct()
		{
		}

		private void SpawnGarteIfWasDespawnedByNPCUnloader()
		{
		}

		private void FlipOffRotationAct()
		{
		}

		private void MirrorRotationAct()
		{
		}

		private void CloakJumpAct()
		{
		}

		private void TribunalAct()
		{
		}
	}
}
