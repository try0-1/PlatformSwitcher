using UnityEngine;
using UnityEditor;
// エディタ拡張のためのクラス
public static class PlatformSwitcher
{
    // メニューバーに表示されるタイトル
    private const string MenuTitle = "File/Platform/";
    // Windowsプラットフォームに切り替えるための関数
    [MenuItem(MenuTitle + "Windows")]
    public static void SwitchToWindowsPlatform()
    {
        SelectPlatform(BuildTargetGroup.Standalone, BuildTarget.StandaloneWindows);
    }
    // MacOSプラットフォームに切り替えるための関数
    [MenuItem(MenuTitle + "MacOS")]
    public static void SwitchToMacOSPlatform()
    {
        SelectPlatform(BuildTargetGroup.Standalone, BuildTarget.StandaloneOSX);
    }
    // Linuxプラットフォームに切り替えるための関数
    [MenuItem(MenuTitle + "Linux")]
    public static void SwitchToLinuxPlatform()
    {
        SelectPlatform(BuildTargetGroup.Standalone, BuildTarget.StandaloneLinux64);
    }
    // Androidプラットフォームに切り替えるための関数
    [MenuItem(MenuTitle + "Android")]
    public static void SwitchToAndroidPlatform()
    {
        SelectPlatform(BuildTargetGroup.Android, BuildTarget.Android);
    }
    // 現在のアクティブなプラットフォームを取得するための関数
    public static void SelectActivePlatform()
    {
        BuildTargetGroup activeBuildTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
        BuildTarget activeBuildTarget = EditorUserBuildSettings.activeBuildTarget;

        SelectPlatform(activeBuildTargetGroup, activeBuildTarget);
    }
    // ビルドターゲットを切り替えるための関数
    private static void SelectPlatform(BuildTargetGroup targetGroup, BuildTarget target)
    {
        EditorUserBuildSettings.SwitchActiveBuildTarget(targetGroup, target);

        // ビルド完了まで待つためのコールバック関数
        EditorApplication.CallbackFunction buildCallback = null;
        buildCallback = () =>
        {
            if (EditorApplication.isCompiling || EditorApplication.isUpdating)
            {
                EditorApplication.delayCall += buildCallback;
            }
            else
            {
                EditorApplication.delayCall -= buildCallback;
                Debug.Log($"Switched to {target} platform");
            }
        };
        buildCallback();
    }
}