using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using Voidforge;

namespace Sunshine
{
	public class LoadScreenOverride : SingletonComponent<LoadScreenOverride>
	{
		[SerializeField]
		private Texture[] defaultLoadScreens;

		[SerializeField]
		private Sprite blackScreen;

		[SerializeField]
		private RawImage loadingSavePanelImage;

		private RawImage imageComponent;

		private bool isBlackScreen;

		private bool isLoadingPanel;

		private bool isDeletingPanel;

		public static event Action<bool> UsingBlackSplashImmediate
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

		public static event Action<bool> UsingBlackSplashInTheNextLoad
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

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		public static void UseSavingPanel()
		{
		}

		public static void UseLoadingPanel()
		{
		}

		public static void UseDeletingPanel()
		{
		}

		public static void UseBlackImmediate(bool enable)
		{
		}

		public static void UseBlackInTheNextLoad(bool enable)
		{
		}

		public static void UseLoadingScreenImageImmediate()
		{
		}

		private static void SwitchToScreenImage()
		{
		}

		private static void SwitchSprite(Sprite sprite)
		{
		}

		private void LoadDone()
		{
		}

		public void SetNewLoadingTexture(Texture2D texture)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected void UpdateSaveLoadPanel()
		{
		}
	}
}
