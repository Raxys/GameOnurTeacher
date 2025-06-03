using UnityEngine;

public class ResolutionChanger : MonoBehaviour
{
    public void SetResolution1920x1080()
    {
        Screen.SetResolution(1920, 1080, Screen.fullScreen);
    }

    public void SetResolution1600x900()
    {
        Screen.SetResolution(1600, 900, Screen.fullScreen);
    }

    public void SetResolution1280x720()
    {
        Screen.SetResolution(1280, 720, Screen.fullScreen);
    }

    public void ToggleFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}

