using UnityEngine;

public class Simple2DMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f; // Hız editörde ayarlanabilir ama dışa açık değil
    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Geri gitmeyi engellemek istersen alttaki satırı aç
        // if (moveY < 0) moveY = 0;

        moveInput = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * moveSpeed;
    }
}
