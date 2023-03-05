Custom Editor Window and Platform Switcher
===========================================

This repository contains two scripts for Unity Editor.

Custom Editor Window
---------------------

The `CustomEditorWindow` script is a custom editor window that allows the user to switch between different platforms. The UI contains four buttons, one for each supported platform (Windows, MacOS, Linux, and Android). Clicking on a button switches the active build target to the corresponding platform.

To use this custom editor window, follow these steps:

1. Import the `CustomEditorWindow.cs` script into your Unity project.
2. In Unity Editor, go to `Window -> Custom Editor` to open the custom editor window.
3. Use the UI to switch between different platforms.

Platform Switcher
------------------

The `PlatformSwitcher` script is a utility class that provides functions for switching between different platforms. It contains four static functions, one for each supported platform (Windows, MacOS, Linux, and Android).

To use this utility class, follow these steps:

1. Import the `PlatformSwitcher.cs` script into your Unity project.
2. Use the `SwitchToWindowsPlatform()`, `SwitchToMacOSPlatform()`, `SwitchToLinuxPlatform()`, or `SwitchToAndroidPlatform()` function to switch the active build target to the corresponding platform.

Note that the `SelectActivePlatform()` function can be used to get the currently active platform.

Enjoy using the Custom Editor Window and Platform Switcher scripts!