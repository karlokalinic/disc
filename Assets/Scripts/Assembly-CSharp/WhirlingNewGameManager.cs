using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Sunshine;
using Voidforge;

public static class WhirlingNewGameManager
{
	private static Timer timer;

	public static bool IsIntroInProgress;

	public static bool isComatose;

	private static readonly int start;

	private static readonly int orbitIsBehindTequila;

	private static readonly int wakingUp;

	private static readonly int interrupt;

	public static bool IsIntroRunning;

	public static bool IsActivityStarting;

	public static event Action OnStateReset
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

	public static void NewGameMode(bool showIntro, bool isActivity = false)
	{
	}

	private static void ResetStates()
	{
	}

	public static void RedButtonPressed()
	{
	}

	public static void LedgerRedButtonPressed()
	{
	}

	public static void StartIntro()
	{
	}

	public static void SkipIntro(bool isActivity)
	{
	}

	public static void EngineStart()
	{
	}

	public static void TequilaHasWokenUp(bool skipIntro)
	{
	}

	public static void FirstOrbClicked()
	{
	}

	public static void InterruptNewGameMode()
	{
	}

	private static void StartIntroMusic()
	{
	}

	private static void StopIntroMusic()
	{
	}

	private static void StartWhiteNoise()
	{
	}

	private static void StopWhiteNoise()
	{
	}

	private static void PauseWhiteNoise()
	{
	}

	private static void LoadWhirlingLevel2(bool isNewGame = false)
	{
	}

	private static void EnableOrbits()
	{
	}

	private static void DisableOrbits()
	{
	}

	private static void EnableOrbs()
	{
	}

	private static void DisableOrbs()
	{
	}

	private static void EnableBlack()
	{
	}

	private static void SuppressHud()
	{
	}

	private static void UnsuppressHud()
	{
	}

	private static void ResetVisualTequilaStates()
	{
	}

	private static void EnableDialogueFuries()
	{
	}

	private static void FlashWhite(bool skipIntro)
	{
	}

	public static void OnLoadingWhirlingLvl2()
	{
	}

	public static void OnLoadWhirlingLvl2SkipIntro()
	{
	}

	public static void OnLoadWhirlingLvl2SkipIntroActivity()
	{
	}

	private static void AssumeComatosePosition()
	{
	}

	private static void StopComatosePosition()
	{
	}

	private static void CameraZoomOut()
	{
	}

	private static IEnumerator PlayNewGameCameraTween(TweenCamera tween)
	{
		return null;
	}

	public static void RegisterEscapeKeyListener()
	{
	}

	public static void UnregisterEscapeKeyListener()
	{
	}

	private static void BlockInput()
	{
	}

	private static void FinalizeLoadingScene()
	{
	}

	private static void TapeEnableBlackBackground()
	{
	}

	private static void TapeDisableBlackBackground()
	{
	}
}
