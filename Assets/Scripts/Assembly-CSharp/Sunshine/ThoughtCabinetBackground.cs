using UnityEngine;
using UnityEngine.UI;

namespace Sunshine
{
	public class ThoughtCabinetBackground : MonoBehaviour
	{
		public static ThoughtCabinetBackground Singleton;

		[SerializeField]
		private Image backgroundImage;

		[SerializeField]
		[Space]
		private float dimStartX;

		[SerializeField]
		private float dimEndX;

		[SerializeField]
		private float animationTime;

		private string start;

		private string end;

		private void Awake()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}
	}
}
