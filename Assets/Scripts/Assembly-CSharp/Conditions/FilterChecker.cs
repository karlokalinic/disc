using CollageMode;
using UnityEngine;

namespace Conditions
{
	public class FilterChecker : BaseCondition
	{
		[SerializeField]
		private SpecialFilter requiredFilter;

		public SpecialFilter RequiredFilter
		{
			get
			{
				return default(SpecialFilter);
			}
			set
			{
			}
		}

		public override bool CheckCondition()
		{
			return false;
		}
	}
}
