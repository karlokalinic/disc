using UnityEngine;
using UnityEngine.AI;

namespace Sunshine
{
	public class Seagull : MonoBehaviour
	{
		private const float SNAPDEGREE = 2f;

		public SeagullWaypoint targetWaypoint;

		public float speed;

		public float turnSpeed;

		private bool isFlying;

		private Vector3 startPoint;

		private Vector3 endPoint;

		private float distance;

		private float travelDistance;

		private NavMeshAgent agent;

		public void Start()
		{
		}

		public void StartFlying()
		{
		}

		public void StartFlying(BoatRideCutsceneSituation cutscene)
		{
		}

		private void Update()
		{
		}
	}
}
