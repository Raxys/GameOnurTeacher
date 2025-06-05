using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject pauseMenu;  // Pause menünüzün GameObject'i
    public GameObject backgroundPanel;  // Siyah yarı şeffaf arka plan paneli

    void Start()
    {
        // Başlangıçta pause menü ve arka plan kapalı olsun
        pauseMenu.SetActive(false);
        backgroundPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            bool isActive = pauseMenu.activeSelf;
            pauseMenu.SetActive(!isActive);
            backgroundPanel.SetActive(!isActive);

            // Oyun durdurma / devam ettirme istersen buraya Time.timeScale ayarları da ekleyebilirsin
        }
    }
}
