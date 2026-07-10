using FortressOccident;
using UnityEngine;
using UnityEngine.AI;

namespace Sunshine
{
	public class EndgameBoat : MonoBehaviour
	{
		public EndgameBoatWaypoint targetWaypoint;

		public float speed;

		public float turnSpeed;

		private bool isBoating;

		private Vector3 startPoint;

		private Vector3 endPoint;

		private float distance;

		private float travelDistance;

		public GameObject boombox;

		public Transform partyParent;

		private NavMeshAgent agentOne;

		private Character characterOne;

		private NavMeshAgent agentTwo;

		private Character characterTwo;

		private static readonly int boatIdleBoombox;

		private static readonly int boatIdleSit;

		private static readonly int tequilaEndBoating;

		private static readonly int kimEndBoating;

		private static readonly int boatIdleStand;

		private NavMeshAgent AgentOne
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private Character CharacterOne
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private NavMeshAgent AgentTwo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private Character CharacterTwo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public void Start()
		{
		}

		public void StartBoating()
		{
		}

		public void StartBoating(BoatRideCutsceneSituation cutscene)
		{
		}

		private void StartCorrectSituation()
		{
		}

		private void EndBoating()
		{
		}

		public static void GetOut()
		{
		}

		private void Update()
		{
		}
	}
}
