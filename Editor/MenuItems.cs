using ZweigStudio.GameViewFocus.Editor;

namespace ZweigStudio.GameViewFocus
{
    using UnityEditor;

    /// <summary>
    /// This class defines all menu items for the Game View Focus asset.
    /// </summary>
    public static class MenuItems
    {
        #region Consts

        private const string MenuItemsBasePath = "Tools/Game View Focus/";

        #endregion

        #region Tools

        /// <summary>
        /// Adds a menu item to toggle Game View Focus' main functionality.
        /// </summary>
        /// <remarks>
        /// Toggle setting is stored in EditorPrefs.
        /// </remarks>
        [MenuItem(MenuItemsBasePath + "Toggle Game View Focus #&F", priority = -11)]
        private static void EnableCursorLock() {
            GameViewFocus.IsEnabled = !GameViewFocus.IsEnabled;
        }
        [MenuItem(MenuItemsBasePath + "Toggle Game View Focus #&F", true)]
        private static bool EnableCursorLockValidate() {
            Menu.SetChecked(MenuItemsBasePath + "Toggle Game View Focus #&F", GameViewFocus.IsEnabled);
            return true;
        }

        #endregion

        #region Tools/Help

        /// <summary>
        /// Adds a menu item to link to the repository on GitHub.
        /// </summary>
        [MenuItem(MenuItemsBasePath + "Find Repository on GitHub", false, 3)]
        private static void OpenGitHub() =>
            EditorUtils.OpenGitHub();

        /// <summary>
        /// Adds a menu item to open an About dialog including the asset's current version and license information.
        /// </summary>
        [MenuItem(MenuItemsBasePath + "About", false, 4)]
        private static void ShowAboutWindow() =>
            EditorUtils.ShowAboutWindow();

        #endregion
    }
}