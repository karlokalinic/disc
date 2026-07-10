using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine.Rendering;

namespace AssetRipperPatches.Editor
{
	public static class BuildPlayerCommand
	{
		public static void BuildWindows64()
		{
			string outputPath = GetArgument("-buildOutput");
			if (string.IsNullOrWhiteSpace(outputPath))
			{
				outputPath = "Builds/Windows/DiscoElysium.exe";
			}

			string[] scenes = EditorBuildSettings.scenes
				.Where(scene => scene.enabled)
				.Select(scene => scene.path)
				.ToArray();

			if (scenes.Length == 0)
			{
				throw new InvalidOperationException("No enabled scenes are configured in EditorBuildSettings.");
			}

			PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.StandaloneWindows64, false);
			PlayerSettings.SetGraphicsAPIs(BuildTarget.StandaloneWindows64, new[] { GraphicsDeviceType.Direct3D11 });

			string directory = Path.GetDirectoryName(outputPath);
			if (!string.IsNullOrEmpty(directory))
			{
				Directory.CreateDirectory(directory);
			}

			BuildReport report = BuildPipeline.BuildPlayer(new BuildPlayerOptions
			{
				scenes = scenes,
				locationPathName = outputPath,
				target = BuildTarget.StandaloneWindows64,
				options = BuildOptions.None
			});

			if (report.summary.result != BuildResult.Succeeded)
			{
				throw new InvalidOperationException($"Windows build failed: {report.summary.result} ({report.summary.totalErrors} errors).");
			}
		}

		private static string GetArgument(string name)
		{
			string[] args = Environment.GetCommandLineArgs();
			for (int i = 0; i < args.Length - 1; i++)
			{
				if (string.Equals(args[i], name, StringComparison.OrdinalIgnoreCase))
				{
					return args[i + 1];
				}
			}

			return null;
		}
	}
}
