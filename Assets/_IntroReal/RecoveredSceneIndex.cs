using UnityEngine;
using UnityEngine.SceneManagement;

public class RecoveredSceneIndex : MonoBehaviour
{
    public string[] sceneNames;
    public string[] sceneTitles;
    Vector2 _scroll;

    void Update()
    {
        for (int i = 0; i < sceneNames.Length && i < 9; i++)
            if (Input.GetKeyDown(KeyCode.Alpha1 + i)) Load(i);
    }

    void OnGUI()
    {
        GUI.Box(new Rect(24, 24, Screen.width - 48, Screen.height - 48), "Recovered DISCO Base Scenes");
        GUI.Label(new Rect(48, 60, Screen.width - 96, 32), "These are source-prefab reconstruction bases generated from the exported project. Number keys 1-9 load the first pages.");
        _scroll = GUI.BeginScrollView(new Rect(48, 104, Screen.width - 96, Screen.height - 152), _scroll, new Rect(0, 0, Screen.width - 128, sceneNames.Length * 48 + 20));
        for (int i = 0; i < sceneNames.Length; i++)
        {
            string title = i < sceneTitles.Length && !string.IsNullOrEmpty(sceneTitles[i]) ? sceneTitles[i] : sceneNames[i];
            if (GUI.Button(new Rect(0, i * 48, Screen.width - 160, 38), (i + 1) + ".  " + title + "   [" + sceneNames[i] + "]")) Load(i);
        }
        GUI.EndScrollView();
    }

    void Load(int index)
    {
        if (index < 0 || index >= sceneNames.Length || string.IsNullOrEmpty(sceneNames[index])) return;
        SceneManager.LoadScene(sceneNames[index]);
    }
}