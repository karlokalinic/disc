using System;
using PixelCrushers.DialogueSystem.TextMeshProSupport;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.Wrappers
{
	[Serializable]
	public class TextMeshProResponseMenuControls : PixelCrushers.DialogueSystem.TextMeshProSupport.TextMeshProResponseMenuControls
	{
		[HideInInspector]
		public TextMeshProResponseButton wrapperButtonTemplate;

		[HideInInspector]
		public TextMeshProResponseButton[] wrapperButtons;

		public UIAutonumberSettings wrapperAutonumber;

		private ObjectPool responsesPool;

		public void Initialize()
		{
		}

		protected override void SetResponseButtons(Response[] responses, Transform target)
		{
		}

		public override void DestroyInstantiatedButtons()
		{
		}

		public override void SetActive(bool value)
		{
		}

		public void SelectFirstResponse()
		{
		}
	}
}
