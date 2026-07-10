using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public static class SequencerTools
	{
		public static Transform GetSubject(string specifier, Transform speaker, Transform listener, Transform defaultSubject = null)
		{
			return null;
		}

		public static bool SpecifierSpecifiesTag(string specifier)
		{
			return false;
		}

		public static string GetSpecifiedTag(string specifier)
		{
			return null;
		}

		public static GameObject FindSpecifier(string specifier, bool onlyActiveInScene = false)
		{
			return null;
		}

		public static string GetDefaultCameraAngle(Transform subject)
		{
			return null;
		}

		public static string GetParameter(string[] parameters, int i, string defaultValue = null)
		{
			return null;
		}

		public static T GetParameterAs<T>(string[] parameters, int i, T defaultValue)
		{
			return default(T);
		}

		public static float GetParameterAsFloat(string[] parameters, int i, float defaultValue = 0f)
		{
			return 0f;
		}

		public static int GetParameterAsInt(string[] parameters, int i, int defaultValue = 0)
		{
			return 0;
		}

		public static bool GetParameterAsBool(string[] parameters, int i, bool defaultValue = false)
		{
			return false;
		}

		public static AudioSource GetAudioSource(Transform subject)
		{
			return null;
		}

		public static bool IsAudioMuted()
		{
			return false;
		}
	}
}
