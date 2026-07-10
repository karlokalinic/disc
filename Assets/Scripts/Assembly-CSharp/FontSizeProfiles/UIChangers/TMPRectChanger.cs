using UnityEngine;

namespace FontSizeProfiles.UIChangers
{
	public class TMPRectChanger : TMPChanger
	{
		[SerializeField]
		private RectTransform rectElement;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		protected override void OnLayoutChanged()
		{
		}
	}
}
