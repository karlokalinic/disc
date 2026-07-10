using Sunshine;
using UnityEngine;
using UnityEngine.Events;
using Voidforge;

namespace FortressOccident
{
	public class TravelDestination : NavMeshClickHandler
	{
		public static ComponentRegistry<string, TravelDestination> knownDestinations;

		public bool MoveToPositionOnArrival;

		public bool RemoveOverlayImageOnArrival;

		public Vector3 target;

		public string areaName;

		public UnityEvent onArrival;

		[GetComponent]
		protected ComponentRef<ManualSoundRemote> manualSoundRemotes;

		protected bool isArriving { get; set; }

		public static bool ArriveAt(string id)
		{
			return false;
		}

		public static void ArriveAt(FormationMarker formationMarker)
		{
		}

		protected bool Arrive()
		{
			return false;
		}

		protected void OnArrival()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
