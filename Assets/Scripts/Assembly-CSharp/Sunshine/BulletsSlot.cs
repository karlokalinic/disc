using UnityEngine;
using UnityEngine.UI;

namespace Sunshine
{
	public class BulletsSlot : MonoBehaviour, IGenericTooltipDataProvider
	{
		[SerializeField]
		private Sprite[] bulletsSprites;

		private Image image;

		private void Awake()
		{
		}

		public void Refresh()
		{
		}

		public GenericTooltipData GetTooltipData()
		{
			return null;
		}
	}
}
