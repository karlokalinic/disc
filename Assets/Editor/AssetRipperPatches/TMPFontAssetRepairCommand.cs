using TMPro;
using UnityEditor;
using UnityEngine;

namespace AssetRipperPatches.Editor
{
	public static class TMPFontAssetRepairCommand
	{
		public static void RepairTMPFontAssets()
		{
			int processed = 0;
			foreach (string guid in AssetDatabase.FindAssets("t:TMP_FontAsset"))
			{
				string path = AssetDatabase.GUIDToAssetPath(guid);
				TMP_FontAsset fontAsset = AssetDatabase.LoadAssetAtPath<TMP_FontAsset>(path);
				if (fontAsset == null)
				{
					continue;
				}

				// Accessing lookup data forces TextMeshPro to refresh old imported font metadata.
				_ = fontAsset.characterLookupTable;
				EditorUtility.SetDirty(fontAsset);
				processed++;
			}

			AssetDatabase.SaveAssets();
			AssetDatabase.Refresh();
			Debug.Log($"Re-saved {processed} TextMeshPro font asset(s).");
		}
	}
}
