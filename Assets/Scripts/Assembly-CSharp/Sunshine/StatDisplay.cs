using Sunshine.Views;
using UnityEngine;

namespace Sunshine
{
	public class StatDisplay : MonoBehaviour
	{
		[SerializeField]
		private ModifiersSection intModifiersSection;

		[SerializeField]
		private ModifiersSection psyModifiersSection;

		[SerializeField]
		private ModifiersSection fysModifiersSection;

		[SerializeField]
		private ModifiersSection motModifiersSection;

		public void Refresh(ViewType currentView)
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void OnLanguageChanged()
		{
		}
	}
}
