using UnityEngine;

namespace Sunshine
{
	public class MaterialStateSwitcher : StateSwitcher
	{
		public Material[] MaterialsForStates;

		private MeshRenderer meshRenderer;

		public override void BecomeActive()
		{
		}

		public override void StopBeingActive()
		{
		}
	}
}
