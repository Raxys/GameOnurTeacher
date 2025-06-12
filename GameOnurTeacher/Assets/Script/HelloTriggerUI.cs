using UnityEngine;
using TMPro;

public class HelloTriggerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI messageText;
    [SerializeField] private string message = "merhaba bugün neþenin doðum günü çok heyecanlýyým";
    [SerializeField] private float displayTime = 3f;       // Mesajýn ekranda kalma süresi  
    [SerializeField] private string playerTag = "Player";

    private void Start()
    {
        messageText.text = "";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            // Mesajý göster, varsa önceki zamanlamayý iptal et, sonra yeniden zamanla
            messageText.text = message;
            CancelInvoke(nameof(ClearMessage));
            Invoke(nameof(ClearMessage), displayTime);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            // Bölgeden çýkýnca hemen iptal et ve sil
            CancelInvoke(nameof(ClearMessage));
            ClearMessage();
        }
    }

    private void ClearMessage()
    {
        messageText.text = "";
    }
}