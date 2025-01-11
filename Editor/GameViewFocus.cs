namespace ZweigStudio.GameViewFocus
{
    using UnityEngine;
    using UnityEditor;

    /// <summary>
    /// This class handles the actual Game View focus when entering Play Mode.
    /// </summary>
    [InitializeOnLoad]
    public static class GameViewFocus
    {
        #region StaticStrings

        internal static string Version => "1.2.1";
        internal static string CommitDate => "January 13, 2025";

        #endregion

        #region Properties

        internal static bool IsEnabled {
            get => EditorPrefs.GetBool("GameViewFocusIsEnabled");
            set => EditorPrefs.SetBool("GameViewFocusIsEnabled", value);
        }

        #endregion

        /// <summary>
        /// On initialization, this constructor registers an event handler to EditorApplication.playModeStateChanged
        /// if Game View Focus is enabled.
        /// </summary>
        static GameViewFocus()
        {
            if (IsEnabled)
            {
                EditorApplication.playModeStateChanged += HandleGameViewFocus;
            }
            else
            {
                EditorApplication.playModeStateChanged -= HandleGameViewFocus;
            }
        }

        /// <summary>
        /// Activates Game View Focus whenever Play Mode is entered and Game View is either maximized or set to Play Focused.
        /// </summary>
        /// <param name="state">Specifies a change in the Editor's Play Mode state. Is provided by EditorApplication.playModeStateChanged event.</param>
        private static void HandleGameViewFocus(PlayModeStateChange state)
        {
            // Only execute Game View Focus when entering Play Mode and Game View is either maximized or set to Play Focused
            if (state != PlayModeStateChange.EnteredPlayMode || IsUnfocused()) return;

            // Get Game View window in Editor
            // Note: Getting the window here is automatically focusing it, but not *focusing* it. It only "highlights" the panel.
            var gameView = EditorWindow.GetWindow(typeof(EditorWindow).Assembly.GetType("UnityEditor.GameView"));

            // Create new MouseDown event
            var mouseDownEvent = new Event
            {
                // Uses a mouse button out of the scope of the usual ones to not interfere with any functions that might
                // be triggered on LMB or RMB clicks
                button = 3,
                clickCount = 1,
                type = EventType.MouseDown,

                // Click in the center of the Game View
                mousePosition = gameView.rootVisualElement.contentRect.center
            };

            // Send Event to actually focus the Game View
            gameView.SendEvent(mouseDownEvent);
        }

        /// <summary>
        /// Returns if the Game View is focused or not. Doesn't make a distinction whether the window is maximized or just set to Play Focused.
        /// </summary>
        /// <returns>True if unfocused, false if focused.</returns>
        private static bool IsUnfocused()
        {
            return EditorWindow.focusedWindow == null || EditorWindow.focusedWindow.titleContent.text != "Game";
        }
    }
}