using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PixelButtonController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public Image targetImage;

    public Sprite normalSprite;
    public Sprite hoveredSprite;
    public Sprite pressedSprite;

    public Vector2 pressedOffset = new Vector2(0, -2); // Moves the button 2 pixels down on press

    private Vector2 originalPosition;

    void Start()
    {
        if (targetImage == null)
            targetImage = GetComponent<Image>();

        originalPosition = GetComponent<RectTransform>().anchoredPosition;
        targetImage.sprite = normalSprite;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        targetImage.sprite = hoveredSprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        targetImage.sprite = normalSprite;
        GetComponent<RectTransform>().anchoredPosition = originalPosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        targetImage.sprite = pressedSprite;
        GetComponent<RectTransform>().anchoredPosition = originalPosition + pressedOffset;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Return to hovered if still hovered, or normal if not
        if (RectTransformUtility.RectangleContainsScreenPoint(
            GetComponent<RectTransform>(), Input.mousePosition, Camera.main))
        {
            targetImage.sprite = hoveredSprite;
        }
        else
        {
            targetImage.sprite = normalSprite;
        }

        GetComponent<RectTransform>().anchoredPosition = originalPosition;
    }
}