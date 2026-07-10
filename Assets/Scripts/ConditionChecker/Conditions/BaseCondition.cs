using UnityEngine;

namespace Conditions
{
	public abstract class BaseCondition : MonoBehaviour
	{
		public abstract bool CheckCondition();

		private void Reset()
		{
		}

		private void FindPotentialCheckers()
		{
		}
	}
}
