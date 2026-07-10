using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	public class TextMeshProBarkUI : MonoBehaviour, IBarkUI
	{
		public TextMeshPro textMeshPro;

		public TextMeshProUGUI textMeshProUGUI;

		public RectTransform panel;

		public bool includeName;

		public float duration;

		public bool waitUntilSequenceEnds;

		public bool checkIfPlayerVisible;

		public LayerMask visibilityLayerMask;

		private float secondsLeft;

		private Transform playerCameraTransform;

		private Collider playerCameraCollider;

		public bool isPlaying => false;

		public event BarkUIDelegate ShowedBark
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event BarkUIDelegate HidBark
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Awake()
		{
		}

		public void Start()
		{
		}

		private void SetActive(bool value)
		{
		}

		public void Update()
		{
		}

		public void Bark(Subtitle subtitle)
		{
		}

		public void OnBarkEnd(Transform actor)
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		private void FadeIn()
		{
		}

		private void FadeOut()
		{
		}

		private void CheckPlayerVisibility()
		{
		}
	}
}
