using Conditions;
using UnityEngine;

namespace CollageMode
{
	public class HiddenImage : ConditionChecker
	{
		[SerializeField]
		private SpriteRenderer spriteRenderer;

		[SerializeField]
		private FadeController fadeController;

		public string ImageID { get; set; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void FilterChanged()
		{
		}

		public void EnableImage(bool value)
		{
		}

		public void SetImage(Sprite imageSprite)
		{
		}
	}
}
