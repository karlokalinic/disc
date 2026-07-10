using CollageMode;
using UnityEngine;

namespace Conditions
{
	public class UnlockChecker : BaseCondition
	{
		[SerializeField]
		private UnlockHiddenImage unlockHiddenImage;

		public override bool CheckCondition()
		{
			return false;
		}
	}
}
