using UnityEngine;

namespace Smaa
{
	[ExecuteInEditMode]
	public class SMAA : MonoBehaviour
	{
		public DebugPass DebugPass;

		public QualityPreset Quality;

		public EdgeDetectionMethod DetectionMethod;

		public bool UsePredication;

		public Preset CustomPreset;

		public PredicationPreset CustomPredicationPreset;

		public Shader Shader;

		public Texture2D AreaTex;

		public Texture2D SearchTex;

		protected Camera m_Camera;

		protected Preset m_LowPreset;

		protected Preset m_MediumPreset;

		protected Preset m_HighPreset;

		protected Preset m_UltraPreset;

		protected Material m_Material;

		public Material Material => null;

		public static bool GlobalToggle { get; private set; }

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private void CreatePresets()
		{
		}
	}
}
