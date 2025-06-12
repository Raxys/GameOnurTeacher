using UnityEngine;

public class AutoSortingLayer : MonoBehaviour
{
    [Header("Sprite Renderers")]
    [SerializeField] private SpriteRenderer groundRenderer;
    [SerializeField] private SpriteRenderer playerRenderer;

    [Header("Layer Ayarları")]
    [SerializeField] private string groundLayerName = "Ground";
    [SerializeField] private int groundOrder = 0;
    [SerializeField] private string playerLayerName = "Player";
    [SerializeField] private int playerOrder = 1;

    private void Awake()
    {
        if (groundRenderer != null)
        {
            groundRenderer.sortingLayerName = groundLayerName;
            groundRenderer.sortingOrder = groundOrder;
        }

        if (playerRenderer != null)
        {
            playerRenderer.sortingLayerName = playerLayerName;
            playerRenderer.sortingOrder = playerOrder;
        }
    }
}
