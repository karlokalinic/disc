using System;
using UnityEditor;
using UnityEngine;

namespace AssetRipperPatches.Editor
{
	/// <summary>
	/// Unity hardware cursors require uncompressed, readable RGBA32 textures without mipmaps.
	/// AssetRipper exports can leave cursor textures on automatic platform compression, which
	/// makes Cursor.SetCursor fail with "texture was not CPU accessible".
	/// </summary>
	public sealed class CursorTextureImportPostprocessor : AssetPostprocessor
	{
		private const string CursorTextureFolder = "Assets/Texture2D";
		private static readonly string[] CursorTexturePlatforms =
		{
			"Standalone",
			"WebGL",
			"Android",
			"iPhone"
		};

		[InitializeOnLoadMethod]
		private static void EnsureExistingCursorTextures()
		{
			EditorApplication.delayCall += ReimportCursorTexturesIfNeeded;
		}

		public static void ReimportCursorTexturesNow()
		{
			ReimportCursorTexturesIfNeeded();
		}

		private static void ReimportCursorTexturesIfNeeded()
		{
			foreach (string guid in AssetDatabase.FindAssets("curs", new[] { CursorTextureFolder }))
			{
				string path = AssetDatabase.GUIDToAssetPath(guid);
				if (!IsCursorTexture(path))
				{
					continue;
				}

				if (AssetImporter.GetAtPath(path) is TextureImporter importer && ApplyCursorSettings(importer))
				{
					importer.SaveAndReimport();
				}
			}
		}

		private void OnPreprocessTexture()
		{
			if (assetImporter is TextureImporter importer && IsCursorTexture(assetPath))
			{
				ApplyCursorSettings(importer);
			}
		}

		private static bool IsCursorTexture(string assetPath)
		{
			if (!assetPath.StartsWith(CursorTextureFolder + "/", StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}

			string fileName = System.IO.Path.GetFileName(assetPath);
			return fileName.StartsWith("curs", StringComparison.OrdinalIgnoreCase)
				&& fileName.EndsWith(".png", StringComparison.OrdinalIgnoreCase);
		}

		private static bool ApplyCursorSettings(TextureImporter importer)
		{
			bool changed = false;

			if (importer.textureType != TextureImporterType.Default)
			{
				importer.textureType = TextureImporterType.Default;
				changed = true;
			}

			if (!importer.isReadable)
			{
				importer.isReadable = true;
				changed = true;
			}

			if (importer.mipmapEnabled)
			{
				importer.mipmapEnabled = false;
				changed = true;
			}

			if (!importer.alphaIsTransparency)
			{
				importer.alphaIsTransparency = true;
				changed = true;
			}

			if (importer.npotScale != TextureImporterNPOTScale.None)
			{
				importer.npotScale = TextureImporterNPOTScale.None;
				changed = true;
			}

			if (importer.textureCompression != TextureImporterCompression.Uncompressed)
			{
				importer.textureCompression = TextureImporterCompression.Uncompressed;
				changed = true;
			}

			if (importer.crunchedCompression)
			{
				importer.crunchedCompression = false;
				changed = true;
			}

			changed |= ApplyDefaultPlatformSettings(importer);
			foreach (string platformName in CursorTexturePlatforms)
			{
				changed |= ApplyPlatformSettings(importer, platformName);
			}

			return changed;
		}

		private static bool ApplyDefaultPlatformSettings(TextureImporter importer)
		{
			TextureImporterPlatformSettings settings = importer.GetDefaultPlatformTextureSettings();
			bool changed = settings.format != TextureImporterFormat.RGBA32
				|| settings.textureCompression != TextureImporterCompression.Uncompressed
				|| settings.crunchedCompression;

			if (!changed)
			{
				return false;
			}

			settings.format = TextureImporterFormat.RGBA32;
			settings.textureCompression = TextureImporterCompression.Uncompressed;
			settings.crunchedCompression = false;
			importer.SetPlatformTextureSettings(settings);
			return true;
		}

		private static bool ApplyPlatformSettings(TextureImporter importer, string platformName)
		{
			TextureImporterPlatformSettings settings = importer.GetPlatformTextureSettings(platformName);
			bool changed = !settings.overridden
				|| settings.format != TextureImporterFormat.RGBA32
				|| settings.textureCompression != TextureImporterCompression.Uncompressed
				|| settings.crunchedCompression;

			if (!changed)
			{
				return false;
			}

			settings.name = platformName;
			settings.overridden = true;
			settings.format = TextureImporterFormat.RGBA32;
			settings.textureCompression = TextureImporterCompression.Uncompressed;
			settings.crunchedCompression = false;
			importer.SetPlatformTextureSettings(settings);
			return true;
		}
	}
}
