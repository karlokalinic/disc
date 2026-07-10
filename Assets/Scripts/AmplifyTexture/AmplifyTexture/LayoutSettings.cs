using System;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public class LayoutSettings
	{
		[SerializeField]
		[HideInInspector]
		public string propDiffuse;

		[HideInInspector]
		[SerializeField]
		public string propNormal;

		[HideInInspector]
		[SerializeField]
		public string propOcclusion;

		[HideInInspector]
		[SerializeField]
		public string propDisplacement;

		[HideInInspector]
		[SerializeField]
		public string propSpecular;

		[HideInInspector]
		[SerializeField]
		public CompressionType rgbCompType;

		[HideInInspector]
		[SerializeField]
		public CompressionType alphaCompType;

		[SerializeField]
		[HideInInspector]
		public CompressionType normalCompType;

		[SerializeField]
		[HideInInspector]
		public CompressionType occlusionCompType;

		[SerializeField]
		[HideInInspector]
		public CompressionType displacementCompType;

		[HideInInspector]
		[SerializeField]
		public CompressionType specularCompType;

		[SerializeField]
		[HideInInspector]
		public int rgbQuality;

		[HideInInspector]
		[SerializeField]
		public int alphaQuality;

		[HideInInspector]
		[SerializeField]
		public int normalQuality;

		[HideInInspector]
		[SerializeField]
		public int occlusionQuality;

		[HideInInspector]
		[SerializeField]
		public int displacementQuality;

		[SerializeField]
		[HideInInspector]
		public int specularQuality;

		[HideInInspector]
		[SerializeField]
		public bool useAlpha;

		[SerializeField]
		[HideInInspector]
		public bool useNormal;

		[SerializeField]
		[HideInInspector]
		public bool useOcclusion;

		[SerializeField]
		[HideInInspector]
		public bool useDisplacement;

		[SerializeField]
		[HideInInspector]
		public bool useSpecular;

		[SerializeField]
		[HideInInspector]
		public bool editUseAlpha;

		[HideInInspector]
		[SerializeField]
		public bool editUseNormal;

		[SerializeField]
		[HideInInspector]
		public bool editUseOcclusion;

		[SerializeField]
		[HideInInspector]
		public bool editUseDisplacement;

		[HideInInspector]
		[SerializeField]
		public bool editUseSpecular;

		[SerializeField]
		[HideInInspector]
		public Color defaultDiffuseValue;

		[HideInInspector]
		[SerializeField]
		public Color defaultNormalValue;

		[HideInInspector]
		[SerializeField]
		public Color defaultOcclusionValue;

		[HideInInspector]
		[SerializeField]
		public Color defaultDisplacementValue;

		[SerializeField]
		[HideInInspector]
		public Color defaultSpecularValue;

		public LayoutSettings()
		{
		}

		public LayoutSettings(LayoutPreset preset)
		{
		}
	}
}
