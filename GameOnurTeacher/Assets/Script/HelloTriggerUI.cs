using UnityEngine;
using TMPro;

public class HelloTriggerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI messageText;
    [SerializeField] private string message = "merhaba bug�n ne�enin do�um g�n� �ok heyecanl�y�m";
    [SerializeField] private float displayTime = 3f;       // Mesaj�n ekranda kalma s�resi  
    [SerializeField] private string playerTag = "Player";

    private void Start()
    {
        messageText.text = "";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            // Mesaj� g�ster, varsa �nceki zamanlamay� iptal et, sonra yeniden zamanla
            messageText.text = message;
            CancelInvoke(nameof(ClearMessage));
            Invoke(nameof(ClearMessage), displayTime);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            // B�lgeden ��k�nca hemen iptal et ve sil
            CancelInvoke(nameof(ClearMessage));
            ClearMessage();
        }
    }

    private void ClearMessage()
    {
        messageText.text = "";
    }
}