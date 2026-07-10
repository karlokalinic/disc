using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public static class AudioResourceOptimizer
	{
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		private static readonly List<string> InternetFilesStartedLoading;

		private static string _supportedLanguageFolder;

		public static void ClearAudioClips()
		{
		}

		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		private static string SupportedLanguageFolder()
		{
			return null;
		}

		public static void ClearSupportLanguageFolder()
		{
		}

		public static AudioClip PopulateResourceSongToPlaylistController(string controllerName, string songResourceName, string playlistName)
		{
			return null;
		}

		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		public static IEnumerator PopulateSourceWithInternetFile(string fileUrl, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		public static void RemoveLoadedInternetClip(string fileUrl)
		{
		}

		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		public static bool PopulateSourcesWithResourceClip(string clipName, SoundGroupVariation variation)
		{
			return false;
		}

		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
}
