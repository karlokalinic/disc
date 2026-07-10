using System.Collections;
using UnityEngine;

namespace FortressOccident
{
	public class TransitionEntity : BasicEntity
	{
		public string area;

		public string destination;

		public bool IsLocked;

		public KimSwitchBoolean[] kimSwitches;

		public override void OnUse(Transform user = null)
		{
		}

		protected override bool CanPlayDialogue()
		{
			return false;
		}

		protected IEnumerator Activate()
		{
			return null;
		}
	}
}
