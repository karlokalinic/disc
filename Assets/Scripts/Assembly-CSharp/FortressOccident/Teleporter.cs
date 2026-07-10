using UnityEngine;
using UnityEngine.Events;

namespace FortressOccident
{
	public class Teleporter : TravelDestination
	{
		[SerializeField]
		protected TravelDestination destination;

		public UnityEvent onActivation;

		protected void OnTriggerEnter(Collider other)
		{
		}
	}
}
