namespace ZweigStudio.GameViewFocus.Demo
{
    using UnityEditor;
    using UnityEngine;

    [CustomEditor(typeof(CursorLock))]
    public class CursorLockInspector : Editor
    {
        private SerializedProperty _cursorLockMode;
        private SerializedProperty _isCursorVisible;

        private void OnEnable()
        {
            _cursorLockMode = serializedObject.FindProperty("cursorLockMode");
            _isCursorVisible = serializedObject.FindProperty("isCursorVisible");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(_cursorLockMode);

            if ((CursorLockMode)_cursorLockMode.enumValueIndex == CursorLockMode.Locked)
            {
                // Set isCursorVisible to FALSE to reflect that it will be hidden anyway while in CursorLockMode.Locked
                // Learn more: https://docs.unity3d.com/ScriptReference/Cursor-lockState.html
                _isCursorVisible.boolValue = false;

                EditorGUI.BeginDisabledGroup(true);
                EditorGUILayout.PropertyField(_isCursorVisible);
                EditorGUI.EndDisabledGroup();

                var helpBoxStyle = GUI.skin.GetStyle("HelpBox");
                helpBoxStyle.richText = true;

                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUIUtility.labelWidth + 2);
                EditorGUILayout.SelectableLabel("Note: A locked cursor is always invisible, regardless of the value of Cursor.visible.", helpBoxStyle, GUILayout.Height(EditorGUIUtility.singleLineHeight));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.Separator();
            }
            else
            {
                EditorGUILayout.PropertyField(_isCursorVisible);
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
