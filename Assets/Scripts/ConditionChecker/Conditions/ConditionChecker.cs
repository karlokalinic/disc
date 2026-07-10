using UnityEngine;

namespace Conditions
{
	public class ConditionChecker : MonoBehaviour
	{
		[SerializeField]
		private bool checkChildren;

		private BaseCondition[] listOfConditions;

		private void Reset()
		{
		}

		private void OnValidate()
		{
		}

		public void FindConditions()
		{
		}

		public bool CheckConditions()
		{
			return false;
		}
	}
}
