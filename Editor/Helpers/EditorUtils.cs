namespace ZweigStudio.GameViewFocus.Editor
{
    using UnityEngine;
    using System;
    using UnityEditor;

    /// <summary>
    /// This utility class offers a custom inspector drawer and some menu item functions.
    /// </summary>
    internal static class EditorUtils
    {
        #region MenuItems

        internal static void OpenGitHub()
        {
            Application.OpenURL("https://github.com/zweigstudio/GameViewFocus");
        }

        internal static void ShowAboutWindow()
        {
            var content = "Version: " + GameViewFocus.Version + " (" + GameViewFocus.CommitDate + ")\n\n" + "Thanks for using Game View Focus!\n\nPublished under MIT license\nCopyright (c) " + DateTime.Now.Year + " Zweig Studio\n\nzweig.studio";
            string[] buttonPrompts = { "Honk", "Jason!", "Pay Respects", "Say Apple", "Pet the Dog", "Meow" };

            EditorUtility.DisplayDialog("Game View Focus", content, buttonPrompts[UnityEngine.Random.Range(0, buttonPrompts.Length)]);
        }

        #endregion
    }
}
