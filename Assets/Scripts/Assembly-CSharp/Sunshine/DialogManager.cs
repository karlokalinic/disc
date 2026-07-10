using UnityEngine;
using Voidforge;

namespace Sunshine
{
	public abstract class DialogManager<T> : SingletonComponent<T> where T : MonoBehaviour
	{
		[SerializeField]
		protected RectTransform rootObject;

		[SerializeField]
		protected bool lockCamera;

		public bool IsVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
