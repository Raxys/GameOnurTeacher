using UnityEngine;

public class ResolutionChecker : MonoBehaviour
{
    void Update()
    {
        Debug.Log("Current resolution: " + Screen.width + "x" + Screen.height);
    }
}
