namespace ZweigStudio.GameViewFocus.Demo
{
    using UnityEngine;

    /// <summary>
    /// This is a very simple example script demonstrating how Game View Focus works.
    /// </summary>
    [AddComponentMenu("Game View Focus/Demo/Cursor Lock")]
    public class CursorLock : MonoBehaviour
    {
        [SerializeField]
        private CursorLockMode cursorLockMode;

        [SerializeField]
        private bool isCursorVisible = true;

        private void Start()
        {
            Cursor.lockState = cursorLockMode;
            Cursor.visible = isCursorVisible;
        }
    }
}
