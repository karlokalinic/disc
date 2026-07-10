using System.Collections;
using FortressOccident;
using UnityEngine;

public class KimSkinSwapper : MonoBehaviour
{
	private const string MAIN_TEXTURE_NAME = "_MainTex";

	[SerializeField]
	private Texture defaultAlbedo;

	[SerializeField]
	private Texture hardcoreAlbedo;

	[SerializeField]
	private Material mat;

	[SerializeField]
	private MouseOverHighlight mouseOverHighlight;

	private bool isHardcoreTexture;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void RefreshHighlightMaterial()
	{
	}

	private void UpdateTexture()
	{
	}

	private IEnumerator RewardAchivementForBlackJacketKim()
	{
		return null;
	}
}
