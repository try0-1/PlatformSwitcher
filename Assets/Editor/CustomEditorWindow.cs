using UnityEngine;
using UnityEditor;
// カスタムエディターウィンドウを作成するクラス
public class CustomEditorWindow : EditorWindow
{
    // エディタメニューからウィンドウを表示するための関数
    [MenuItem("Window/Custom Editor")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(CustomEditorWindow));
    }
    // ウィンドウ上にUI要素を表示するための関数
    private void OnGUI()
    {
        GUILayout.Label("Custom Editor Window", EditorStyles.boldLabel);
        // Windowsプラットフォームに切り替える
        if (GUILayout.Button("Switch to Windows"))
        {
            PlatformSwitcher.SwitchToWindowsPlatform();
        }

        if (GUILayout.Button("Switch to MacOS"))
        {
            PlatformSwitcher.SwitchToMacOSPlatform();
        }

        if (GUILayout.Button("Switch to Linux"))
        {
            PlatformSwitcher.SwitchToLinuxPlatform();
        }

        if (GUILayout.Button("Switch to Android"))
        {
            PlatformSwitcher.SwitchToAndroidPlatform();
        }
    }
}