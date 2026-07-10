using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Charsheet
{
	public class SkillPortrayLabel : MonoBehaviour
	{
		public RectTransform nameplateRect;

		public Image nameplateBackground;

		public TextMeshProUGUI skillName;

		public TextMeshProUGUI skillNumber;

		public Vector2 StartLocalPosition { get; private set; }

		public Vector2 StartLabelLocalPosition { get; private set; }

		private void Awake()
		{
		}
	}
}
