using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public int itemCount = 0;
    public int totalItems = 3;
    

    public Text itemCountText;
    public Text ePromptText;

    private GameObject currentItem = null;

    void Start()
    {
        ePromptText.gameObject.SetActive(false);
        UpdateItemCountText();
    }

    void Update()
    {
        // "E" tu�una bas�ld���nda item varsa
        if (Input.GetKeyDown(KeyCode.E) && currentItem != null)
        {
            itemCount++;
            Destroy(currentItem);   // Item'� yok et
            currentItem = null;

            // UI g�ncelle
            UpdateItemCountText();
            ePromptText.gameObject.SetActive(false);

           
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            currentItem = other.gameObject;
            ePromptText.text = "Toplamak i�in [E]"; // Dinamik mesaj
            ePromptText.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == currentItem)
        {
            currentItem = null;
            ePromptText.gameObject.SetActive(false);
        }
    }

    void UpdateItemCountText()
    {
        if (itemCountText != null)
        {
            itemCountText.text = "Items Collected: " + itemCount + " / " + totalItems;
        }
    }
}

