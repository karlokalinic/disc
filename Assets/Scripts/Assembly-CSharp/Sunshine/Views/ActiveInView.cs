using UnityEngine;

namespace Sunshine.Views
{
	public class ActiveInView : MonoBehaviour
	{
		public ViewType[] activeViews;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnViewChanged(ViewType view)
		{
		}
	}
}
