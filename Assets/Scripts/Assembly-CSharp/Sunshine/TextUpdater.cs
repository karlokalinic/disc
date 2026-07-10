using FortressOccident;
using TMPro;
using UnityEngine;
using Voidforge;

namespace Sunshine
{
	public class TextUpdater : FOComponent
	{
		[SerializeField]
		protected TextMeshProUGUI textObject;

		[SerializeField]
		protected FOComponent textSource;

		protected ComponentRef<TextMeshProUGUI> text;

		protected void Update()
		{
		}
	}
}
