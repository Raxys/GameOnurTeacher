using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void ExitGame()
    {
#if UNITY_EDITOR
       
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // If you're running a built version of the game
            Application.Quit();
#endif
    }
}
