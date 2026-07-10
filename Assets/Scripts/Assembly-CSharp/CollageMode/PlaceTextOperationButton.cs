using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class PlaceTextOperationButton : BaseOperationButton
	{
		[SerializeField]
		private TextMeshProUGUI text;

		[SerializeField]
		private Localize textLocalize;

		[SerializeField]
		private Image background;

		public override void Init(Operation operation)
		{
		}
	}
}
