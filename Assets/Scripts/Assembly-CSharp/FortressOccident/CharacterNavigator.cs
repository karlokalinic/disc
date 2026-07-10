using UnityEngine;
using UnityEngine.AI;
using Voidforge;

namespace FortressOccident
{
	public class CharacterNavigator : FOComponent
	{
		private const float DESTINATION_DIST_ERROR = 0f;

		[SerializeField]
		protected float walkSpeed;

		[SerializeField]
		protected float runSpeed;

		[SerializeField]
		protected float autoRunDistance;

		[GetComponent]
		protected ComponentRef<Character> character;

		[GetComponent]
		private ComponentRef<NavMeshAgent> navAgent;

		private const float MAX_INTERACT_RADIUS = 1f;

		public Vector3 desiredVelocity => default(Vector3);

		public float heading
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float height => 0f;

		public bool HasNavAgent => false;

		public NavMeshAgent GetNavAgent => null;

		public Vector3 pathEndPosition => default(Vector3);

		public float stoppingDistance => 0f;

		public bool hasPath => false;

		public bool isOnNavMesh => false;

		public bool isReady => false;

		protected bool isRunning => false;

		public void ResetPath()
		{
		}

		public bool SetDestination(Vector3 targetPosition)
		{
			return false;
		}

		public void SetPosition(Vector3 value, bool warp = false)
		{
		}

		public bool HasReachedDestination()
		{
			return false;
		}

		protected void FixedUpdate()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}
	}
}
