using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Oyunu durdurduysan tekrar başlat
        SceneManager.LoadScene(0); // ya da index numarası: LoadScene(0);
    }
}
