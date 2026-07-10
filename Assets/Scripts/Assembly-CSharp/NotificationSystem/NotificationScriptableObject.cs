using LocalizationCustomSystem;
using UnityEngine;

namespace NotificationSystem
{
	[CreateAssetMenu]
	public class NotificationScriptableObject : ScriptableObject
	{
		public NotificationType NotificationType;

		public string DefaultHeader;

		public TranslationString LocalizedDefaultHeaderTerm;

		public string localizedHeaderSuffix;

		public Sprite MainSprite;

		public Sprite BlurSprite;

		public Sprite LeftSecondarySprite;

		public Sprite LeftSecondaryBlurSprite;

		public Sprite RightSecondarySprite;

		public Sprite RightSecondaryBlurSprite;

		public Color NeonColor;

		public Color LabelColor;

		public Color ScreenFlash;

		public HideSide HideSide;

		public float ShowingTime;

		public float StayTime;

		public float HidingTime;

		public float SlideDist;

		public string audioClipGroup;

		public string audioClipId;

		public bool WaitingForAction;

		public string cameraFX;

		public string[] cameraFXArray;
	}
}
