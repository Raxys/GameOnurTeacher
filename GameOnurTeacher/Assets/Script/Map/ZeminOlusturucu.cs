using UnityEngine;

public class ZeminOlusturucu : MonoBehaviour
{
    [SerializeField] private Vector2 zeminBoyutu = new Vector2(20f, 1f);
    [SerializeField] private Vector2 zeminPozisyonu = new Vector2(0f, -3f);
    [SerializeField] private Material zeminMaterial;

    void Start()
    {
        // Zemin nesnesini oluştur
        GameObject zemin = new GameObject("Zemin");
        zemin.transform.position = zeminPozisyonu;

        // Sprite Renderer ekle (isteğe bağlı görsel için)
        SpriteRenderer sr = zemin.AddComponent<SpriteRenderer>();
        sr.sprite = Sprite.Create(Texture2D.whiteTexture, new Rect(0,0,1,1), Vector2.one * 0.5f);
        sr.drawMode = SpriteDrawMode.Sliced;
        sr.size = zeminBoyutu;
        sr.color = Color.gray;

        if (zeminMaterial != null)
            sr.material = zeminMaterial;

        // Collider ekle
        BoxCollider2D collider = zemin.AddComponent<BoxCollider2D>();

        // Rigidbody ekle (hareket etmeyen nesne için)
        Rigidbody2D rb = zemin.AddComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Static;
    }
}
