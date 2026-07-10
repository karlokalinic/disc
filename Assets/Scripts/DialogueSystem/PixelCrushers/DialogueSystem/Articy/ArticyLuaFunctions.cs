using UnityEngine;

namespace PixelCrushers.DialogueSystem.Articy
{
	public class ArticyLuaFunctions : MonoBehaviour
	{
		private static bool s_registered;

		private void OnEnable()
		{
		}

		private void OnConversationLine(Subtitle subtitle)
		{
		}

		public static string getObj(string objectName)
		{
			return null;
		}

		public static object getProp(string objectIdentifier, string propertyName)
		{
			return null;
		}

		public static void setProp(string objectIdentifier, string propertyName, object value)
		{
		}

		private static string GetShortPropertyName(string propertyName)
		{
			return null;
		}
	}
}
