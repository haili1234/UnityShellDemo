using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;

public class BuildShellScript
{
    [MenuItem("Tools/BuildSettingShell/BuildiOS")]
    [System.Obsolete]
    public static void PerformiOSBuild()
    {
        EditorUserBuildSettings.activeBuildTargetChanged = delegate ()
        {
            if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.iOS)
            {
               
            }
        };
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.iOS);

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        //buildPlayerOptions.scenes = new[] { "Assets/Scenes/Scene1.unity", "Assets/Scenes/Scene2.unity" };
        buildPlayerOptions.locationPathName = "../UnityAppBuild/iOSBuild";
        buildPlayerOptions.target = BuildTarget.iOS;
        buildPlayerOptions.options = BuildOptions.None;

        // 调用开始打包  
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log("Build succeeded: " + summary.totalSize + " bytes");
        }

        if (summary.result == BuildResult.Failed)
        {
            Debug.Log("Build failed");
        }

    }

    [MenuItem("Tools/BuildSettingShell/BuildAndroid")]
    [System.Obsolete]
    public static void PerformAndroidBuild()
    {
        EditorUserBuildSettings.activeBuildTargetChanged = delegate () {
            if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.Android)
            {
             
            }
        };
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);

        //PlayerSettings.productName = "testShellDemo";
        EditorUserBuildSettings.exportAsGoogleAndroidProject = true;
        BuildPlayerOptions buildPlayerOptions= new BuildPlayerOptions();
        buildPlayerOptions.locationPathName = "../UnityAppBuild/AndroidBuild";

        // buildPlayerOptionss.options |= BuildOptions.AcceptExternalModificationsToPlayer;
        // buildPlayerOptionss.scenes = new[] { "Assets/Scenes/Scene1.unity", "Assets/Scenes/Scene2.unity" };
        buildPlayerOptions.target = BuildTarget.Android;
        // 调用开始打包   
        BuildPipeline.BuildPlayer(buildPlayerOptions);

    }
}

  
