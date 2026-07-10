using System.Runtime.CompilerServices;

namespace PixelCrushers
{
	public static class SceneNotifier
	{
		public delegate void UnloadSceneDelegate(int sceneIndex);

		public static event UnloadSceneDelegate willUnloadScene
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

		public static void NotifyWillUnloadScene(int sceneIndex)
		{
		}
	}
}
