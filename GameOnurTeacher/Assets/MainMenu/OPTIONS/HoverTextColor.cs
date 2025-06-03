using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class HoverTextColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI targetText;
    public Color normalColor = Color.white;
    public Color hoverColor = Color.white;

    public void OnPointerEnter(PointerEventData eventData)
    {
        targetText.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        targetText.color = normalColor;
    }
}
