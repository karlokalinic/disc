using FortressOccident;
using UnityEngine;
using UnityEngine.AI;

namespace Sunshine
{
	public class MovementCommand
	{
		protected static NavMeshPath _navPath;

		protected static Vector3[] _navPathCorners;

		protected float? _cost;

		protected Formation _from;

		protected Formation _to;

		protected Party _party;

		public bool calculateHeading { get; set; }

		public float cost => 0f;

		public float memberCost => 0f;

		public Formation from => default(Formation);

		public MovementMode mode { get; set; }

		public Formation.Purpose purpose { get; set; }

		public Formation to
		{
			get
			{
				return default(Formation);
			}
			private set
			{
			}
		}

		public MovementCommand(Party party, bool calculateFinalHeading)
		{
		}

		public void Clear()
		{
		}

		public void Process(Vector3 target, Sector sector, bool predefinedSectorPos = false)
		{
		}

		public void Process(Component target, Sector sector)
		{
		}

		protected float CalculateMovementCost(Formation target)
		{
			return 0f;
		}

		public static float CalculateMovementCost(int characterIndex, Formation origin, Formation target, MovementMode mode)
		{
			return 0f;
		}
	}
}
