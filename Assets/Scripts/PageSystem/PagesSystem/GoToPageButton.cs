using UnityEngine;

namespace PagesSystem
{
	public class GoToPageButton : MonoBehaviour
	{
		[SerializeField]
		private PageStack stack;

		public string PageName;

		public bool IsPopUp;

		private void Awake()
		{
		}
	}
}
