using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject backgroundPanel;
    public OptionsSlide optionsSlide; // Bu scriptin referansı lazım

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        backgroundPanel.SetActive(false);

        if (optionsSlide != null)
        {
            optionsSlide.HideOptions(); // Options menüsünü kapat
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
        backgroundPanel.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 0f)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
}

