using System.Collections.Generic;
using UnityEngine;

namespace FortressOccident
{
	public class FeldBase : MonoBehaviour
	{
		public float speedMultiplier;

		public float lengthMultiplier;

		public float preDelay;

		public bool mainTape;

		private Material[] mats;

		private int[] matIds;

		private const int MaxGlobalArraySize = 80;

		private static HashSet<Material> register;

		private static Vector4[] globalPackedArray;

		private static Vector4[] globalColorArray;

		private static int lastFrame;

		private static int propId_FOTape_PackedArray;

		private static int propId_FOTape_ColorArray;

		private static int propId_UIPosition;

		private static int propId_UIWind;

		private static int propId_UISpecShift;

		private static int propId_MatId;

		private static int propId_Position;

		private static int propId_Speed;

		private static int propId_BlurMix;

		private static int propId_SpecShift;

		private static int propId_Color;

		private Shader tapeShader;

		private float aniLength;

		private float aniSpeed;

		private float aniStart;

		private float initialAlpha;

		private float fromAlpha;

		private float currentAlpha;

		private float targetAlpha;

		private float alphaTime;

		private float transitionSpeed;

		private AnimationCurve currentAnimation;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void InitializeGlobalArrays()
		{
		}

		private static void SetGlobalConstants()
		{
		}

		private void SetPosition(int i, float value)
		{
		}

		private float GetPosition(int i)
		{
			return 0f;
		}

		private void SetSpeed(int i, float value)
		{
		}

		private void SetBlurMix(int i, float value)
		{
		}

		private void SetSpecShift(int i, float value)
		{
		}

		private void SetColor(int i, Color value)
		{
		}

		private Color GetColor(int i)
		{
			return default(Color);
		}

		public void Animate(AnimationCurve curve, float time = 1f, float speed = 1f, string clipStart = "", string clipEnd = "")
		{
		}

		public void Move(float amount = 0f)
		{
		}

		private void UpdateMaterial()
		{
		}

		public void FeldFadeout()
		{
		}

		public void FeldFadein()
		{
		}

		private float GetAlpha()
		{
			return 0f;
		}

		private void SetAlpha(float alpha)
		{
		}

		private void UpdateAlpha()
		{
		}

		private void Update()
		{
		}

		public void OnH()
		{
		}

		public void OnK()
		{
		}

		public void OnL()
		{
		}
	}
}
