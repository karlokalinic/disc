// BuildPlayerDisco — produces the deploy-ready Windows player from the enabled build-settings scenes
// (original UI entry + recovered world scenes). Run:
//   Unity -batchmode -quit -projectPath <proj> -executeMethod BuildPlayerDisco.Build
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;

public static class BuildPlayerDisco
{
    public static void Build()
    {
        var scenes = new List<string>();
        foreach (var s in EditorBuildSettings.scenes) if (s.enabled) scenes.Add(s.path);

        string dir = Path.Combine(Directory.GetParent(Application.dataPath).FullName, "Builds", "DiscoDeploy");
        if (Directory.Exists(dir)) Directory.Delete(dir, true);
        Directory.CreateDirectory(dir);
        string exe = Path.Combine(dir, "DiscoElysium.exe");

        var opts = new BuildPlayerOptions {
            scenes = scenes.ToArray(),
            locationPathName = exe,
            target = BuildTarget.StandaloneWindows64,
            options = BuildOptions.None
        };

        Debug.Log("[BUILD] scenes=" + string.Join(", ", scenes));
        var report = BuildPipeline.BuildPlayer(opts);
        var sum = report.summary;
        Debug.Log("[BUILD] result=" + sum.result + " size=" + sum.totalSize + " errors=" + sum.totalErrors + " warnings=" + sum.totalWarnings);
        File.WriteAllText(Path.Combine(Directory.GetParent(Application.dataPath).FullName, "build_result.txt"),
            "result=" + sum.result + "\nerrors=" + sum.totalErrors + "\nexe=" + exe + "\n");
    }
}
