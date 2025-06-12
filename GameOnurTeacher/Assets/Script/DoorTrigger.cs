using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // UI kullanımı için

public class DoorTrigger : MonoBehaviour
{
    public string nextSceneName; // Sahne adı (Inspector'dan ayarlanır)
    public Text promptText; // Ekrana yazı göstermek için UI Text

    private bool isPlayerInRange = false;

    void Start()
    {
        // Oyun başladığında yazı gizli olsun
        if (promptText != null)
        {
            promptText.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (isPlayerInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(nextSceneName); // Sahneyi yükle
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            if (promptText != null)
            {
                promptText.text = "İçeri girmek için [E] tuşuna bas";
                promptText.gameObject.SetActive(true);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            if (promptText != null)
            {
                promptText.gameObject.SetActive(false);
            }
        }
    }
}
