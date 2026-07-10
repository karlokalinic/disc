using System.Collections;
using System.Collections.Generic;
using FortressOccident;
using UnityEngine;

public class InteractableRenderer : MonoBehaviour
{
	public static BasicEntity entityBookmark;

	public static SenseOrb orbBookmark;

	public static InteractableRenderer current;

	private static Coroutine updateOrbCacheCoR;

	private static Coroutine shakeupInteractablesCoR;

	private static bool orbsEnabled;

	private static bool orbitsEnabled;

	private static int orbBookmarkIndex;

	private static int entityBookmarkIndex;

	public OrbUiElement orbTemplate;

	public Sprite genericOrbBackground;

	public Sprite dialogueOrbBackgound;

	public Sprite freshnessIndicator;

	[HideInInspector]
	public int renderObject;

	public List<OrbUiElement> OrbUIList;

	private bool dirty;

	private GenericObjectPool<OrbUiElement> orbUiElementsPool;

	public static bool OrbsEnabled => false;

	public static bool OrbitsEnabled => false;

	private void Awake()
	{
	}

	private OrbUiElement CreateOrbUi()
	{
		return null;
	}

	private void OnGetOrbUiFromPool(OrbUiElement orbUi)
	{
	}

	private void OnReleaseOrbUiToPool(OrbUiElement orbUi)
	{
	}

	public void DestroyOrbUI(OrbUiElement orbUi)
	{
	}

	public OrbUiElement GetOrCreateOrbUi(SenseOrb orb)
	{
		return null;
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	public static void SwitchOrbs(bool state)
	{
	}

	public static void SwitchOrbits(bool state)
	{
	}

	public static void UpdateOrbCache()
	{
	}

	public static void Shakeup()
	{
	}

	public void EnableOrbs()
	{
	}

	public void DisableOrbs()
	{
	}

	public void EnableOrbits()
	{
	}

	public void DisableOrbits()
	{
	}

	public void SetDirty()
	{
	}

	private static void ShakeupInteractables()
	{
	}

	private static IEnumerator SlowShakeupInteractables()
	{
		return null;
	}

	private static void ShakeupOrbs()
	{
	}

	private void DetachTemplates()
	{
	}

	private static IEnumerator SlowUpdateOrbCache()
	{
		return null;
	}

	private void LevelLoadOrbReset()
	{
	}
}
