using UnityEngine;
using UnityEngine.UI;

public class OptionsSlide : MonoBehaviour
{
    public RectTransform optionsMenu;
    private bool isOpen = false;

    private void Start()
    {
        // Başlangıçta ekran dışı konuma yerleştir
        optionsMenu.anchoredPosition = new Vector2(665.8f, -364.2561f);
    }

    public void ToggleOptions()
    {
        if (isOpen)
        {
            // Menü kapanınca tekrar dışarı çık
            LeanTween.move(optionsMenu, new Vector2(665.8f, -364.2561f), 0.3f).setEase(LeanTweenType.easeInOutQuad);
        }
        else
        {
            // Menü açılınca ekran içine gelsin (bu senin istediğin pozisyon)
            LeanTween.move(optionsMenu, new Vector2(-665.9f, -364.2561f), 0.3f).setEase(LeanTweenType.easeInOutQuad);
        }

        isOpen = !isOpen;
    }

    public void HideOptions()
    {
        if (isOpen)
        {
            LeanTween.move(optionsMenu, new Vector2(665.8f, -364.2561f), 0.3f).setEase(LeanTweenType.easeInOutQuad);
            isOpen = false;
        }
    }
}