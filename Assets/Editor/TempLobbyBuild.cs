// TEMP build helper - builds original Lobby scene only. Removed after test.
using UnityEditor;
public static class TempLobbyBuild
{
    public static void Run()
    {
        BuildPipeline.BuildPlayer(new[]{"Assets/Scenes/Lobby.unity"}, "Builds/LobbyOnly/LobbyOnly.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);
    }
}
