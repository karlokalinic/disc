using UnityEngine;
using Voidforge;

namespace Sunshine
{
	public class DeveloperPlaceholder : MonoBehaviour
	{
		private static ComponentRegistry<DeveloperPlaceholder> _allPlaceholders;

		public DeactivatableObject Deactivator { get; private set; }

		protected void Awake()
		{
		}

		protected void OnDestroy()
		{
		}

		private static void SetDeveloperState(DeveloperPlaceholder obj, bool value)
		{
		}

		public static void SetActive(bool value)
		{
		}
	}
}
