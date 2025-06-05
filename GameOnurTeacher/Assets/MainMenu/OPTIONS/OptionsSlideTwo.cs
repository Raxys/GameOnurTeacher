using UnityEngine;
using UnityEngine.UI;

public class OptionsSlideTwo : MonoBehaviour
{
    public RectTransform optionsMenu;
    private bool isOpen = false;

    private void Start()
    {
        optionsMenu.anchoredPosition = new Vector2(486.8f, -191.8f);
        optionsMenu.gameObject.SetActive(true); // Başlangıçta kapalı tut
    }

    public void ToggleOptions()
    {
        if (isOpen)
        {
            LeanTween.move(optionsMenu, new Vector2(486.8f, -191.8f), 0.3f)
                .setEase(LeanTweenType.easeInOutQuad)
                .setIgnoreTimeScale(true);
        }
        else
        {
            LeanTween.move(optionsMenu, new Vector2(-486.8f, -191.8f), 0.3f)
                .setEase(LeanTweenType.easeInOutQuad)
                .setIgnoreTimeScale(true);
        }

        isOpen = !isOpen;
    }


   public void HideOptions()
{
    if (isOpen)
    {
        LeanTween.move(optionsMenu, new Vector2(486.8f, -191.8f), 0.3f).setEase(LeanTweenType.easeInOutQuad)
            .setOnComplete(() =>
            {
                optionsMenu.gameObject.SetActive(false);
                isOpen = false;
            });
    }
}

}

