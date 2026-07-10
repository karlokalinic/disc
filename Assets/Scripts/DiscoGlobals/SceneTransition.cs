using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public static class SceneTransition
{
	private static readonly Dictionary<Scene, UnityEvent> OnSceneLoadedActionsDict;

	private static readonly Dictionary<Scene, UnityEvent> OnSceneUnloadedActionsDict;

	public static event UnityAction<Scene> sceneUnloaded
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

	public static event UnityAction<Scene, LoadSceneMode> sceneLoaded
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

	public static void TriggerSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
	{
	}

	public static void TriggerSceneUnloaded(Scene scene)
	{
	}

	public static Scene GetKeyScene(Scene scene)
	{
		return default(Scene);
	}

	public static void AddListenerToOnSceneActivated(Scene scene, UnityAction action)
	{
	}

	public static void AddListenerToOnSceneDeactivated(Scene scene, UnityAction action)
	{
	}

	public static void RemoveListenerFromOnSceneActivated(Scene scene, UnityAction action)
	{
	}

	public static void RemoveListenerFromOnSceneDeactivated(Scene scene, UnityAction action)
	{
	}
}
