using FortressOccident;
using UnityEngine;

namespace Sunshine
{
	public class MoneyItem : BasicEntity
	{
		[SerializeField]
		public int amount;

		public override void OnUse(Transform user = null)
		{
		}
	}
}
