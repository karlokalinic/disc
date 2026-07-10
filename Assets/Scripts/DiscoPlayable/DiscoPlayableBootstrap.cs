using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DiscoPlayable
{
    public sealed class DiscoPlayableBootstrap : MonoBehaviour
    {
        private enum ScreenState { MainMenu, Archetypes, Charsheet, Opening }

        private const string RecoveredWorldIndexScene = "RecoveredSceneIndex";

        private readonly List<GameObject> _mainMenuRoots = new List<GameObject>();
        private readonly List<GameObject> _archetypeRoots = new List<GameObject>();
        private readonly List<GameObject> _charsheetRoots = new List<GameObject>();
        private ScreenState _state;
        private bool _wired;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void Install()
        {
            if (FindAnyObjectByType<DiscoPlayableBootstrap>() != null) return;
            var host = new GameObject("[DiscoPlayableBootstrap]");
            DontDestroyOnLoad(host);
            host.AddComponent<DiscoPlayableBootstrap>();
        }

        private void OnEnable()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        private void OnDisable()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }

        private void Start()
        {
            ConfigureCurrentScene();
        }

        private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            ConfigureCurrentScene();
        }

        private void Update()
        {
            if (!_wired) return;

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (_state == ScreenState.Charsheet) ShowArchetypes();
                else if (_state == ScreenState.Archetypes) ShowMainMenu();
            }

            if (_state == ScreenState.MainMenu && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space)))
                ShowArchetypes();
            else if (_state == ScreenState.Archetypes && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space)))
                ShowCharsheet();
        }

        private void ConfigureCurrentScene()
        {
            _wired = false;
            _mainMenuRoots.Clear();
            _archetypeRoots.Clear();
            _charsheetRoots.Clear();

            EnsureEventSystem();
            EnsureCameraAudioListener();
            DisableFragileRectMasks();

            var roots = SceneManager.GetActiveScene().GetRootGameObjects();
            foreach (var root in roots)
            {
                foreach (var transform in root.GetComponentsInChildren<Transform>(true))
                {
                    var name = transform.name;
                    var lower = name.ToLowerInvariant();
                    if (name == "MainMenu" || name == "MainMenuImage" || name == "MainMenuHUD" || name == "HUD Main Menu" || name == "_MENU" || name == "_MENU-label")
                        AddUnique(_mainMenuRoots, transform.gameObject);
                    if (lower.Contains("archetype") || name == "Custom Character Button")
                        AddUnique(_archetypeRoots, transform.gameObject);
                    if (lower.Contains("charsheet") || lower.Contains("character sheet") || name == "CharacterRotationArea" || name == "TapeCharSheet")
                        AddUnique(_charsheetRoots, transform.gameObject);
                }
            }

            // If the active scene is not the menu scene, still keep the bootstrap quiet.
            if (_mainMenuRoots.Count == 0 && _archetypeRoots.Count == 0 && _charsheetRoots.Count == 0)
                return;

            WireButtons();
            ShowMainMenu();
            _wired = true;
            Debug.Log($"[DiscoPlayable] Wired scene '{SceneManager.GetActiveScene().name}' using ripped UI roots: main={_mainMenuRoots.Count}, archetype={_archetypeRoots.Count}, charsheet={_charsheetRoots.Count}");
        }

        private static void AddUnique(List<GameObject> list, GameObject go)
        {
            if (go != null && !list.Contains(go)) list.Add(go);
        }

        private void WireButtons()
        {
            foreach (var button in FindObjectsByType<Button>(FindObjectsInactive.Include))
            {
                string n = button.name.ToLowerInvariant();
                button.onClick.RemoveAllListeners();
                if (n.Contains("new game") || n.Contains("newgame") || n.Contains("archetype") || n.Contains("custom character"))
                    button.onClick.AddListener(ShowArchetypes);
                else if (n.Contains("continue"))
                    button.onClick.AddListener(ShowCharsheet);
                else if (n.Contains("back") || n.Contains("return"))
                    button.onClick.AddListener(ShowMainMenu);
                else if (n.Contains("begin") || n.Contains("start") || n.Contains("done"))
                    button.onClick.AddListener(ShowOpening);
            }
        }

        private void ShowMainMenu()
        {
            _state = ScreenState.MainMenu;
            SetList(_mainMenuRoots, true);
            SetList(_archetypeRoots, false);
            SetList(_charsheetRoots, false);
        }

        private void ShowArchetypes()
        {
            _state = ScreenState.Archetypes;
            SetList(_mainMenuRoots, false);
            SetList(_archetypeRoots, true);
            SetList(_charsheetRoots, false);
        }

        private void ShowCharsheet()
        {
            _state = ScreenState.Charsheet;
            SetList(_mainMenuRoots, false);
            SetList(_archetypeRoots, false);
            SetList(_charsheetRoots, true);
        }

        private void ShowOpening()
        {
            _state = ScreenState.Opening;
            SetList(_mainMenuRoots, false);
            SetList(_archetypeRoots, false);
            SetList(_charsheetRoots, false);
            SceneManager.LoadScene(RecoveredWorldIndexScene);
        }

        private static void SetList(List<GameObject> roots, bool active)
        {
            foreach (var go in roots)
                if (go != null) go.SetActive(active);
        }

        private static void EnsureEventSystem()
        {
            if (FindAnyObjectByType<EventSystem>() != null) return;
            var go = new GameObject("EventSystem");
            go.AddComponent<EventSystem>();
            go.AddComponent<StandaloneInputModule>();
        }

        private static void EnsureCameraAudioListener()
        {
            var listeners = FindObjectsByType<AudioListener>(FindObjectsInactive.Include);
            bool kept = false;
            foreach (var listener in listeners)
            {
                if (!kept && listener.isActiveAndEnabled)
                {
                    kept = true;
                    continue;
                }
                listener.enabled = false;
            }

            var cam = Camera.main;
            if (cam != null && cam.GetComponent<AudioListener>() == null && !kept)
                cam.gameObject.AddComponent<AudioListener>();
        }

        private static void DisableFragileRectMasks()
        {
            foreach (var mask in FindObjectsByType<RectMask2D>(FindObjectsInactive.Include))
                mask.enabled = false;
        }
    }
}
