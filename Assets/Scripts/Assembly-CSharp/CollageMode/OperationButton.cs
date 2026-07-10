using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class OperationButton : BaseOperationButton
	{
		[SerializeField]
		private Button favouriteButton;

		[SerializeField]
		private Image favouriteImage;

		[SerializeField]
		private Image image;

		[SerializeField]
		private TextMeshProUGUI debugNameText;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void Init(Operation operation)
		{
		}

		private void OnFavouriteClicked()
		{
		}

		private void RefreshFavouriteImage()
		{
		}
	}
}
