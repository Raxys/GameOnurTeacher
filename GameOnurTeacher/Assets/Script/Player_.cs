using UnityEngine;

public class Simple2DMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Animator anim;

    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Normalize edilmiş hareket vektörü
        moveInput = new Vector2(moveX, moveY).normalized;

        // Tüm yönleri önce kapat
        anim.SetBool("Right", false);
        anim.SetBool("Left", false);
        anim.SetBool("top", false);
        anim.SetBool("down", false);

        // Hangi yön daha baskınsa o animasyon aktif olsun
        if (moveInput != Vector2.zero)
        {
            if (Mathf.Abs(moveX) > Mathf.Abs(moveY))
            {
                if (moveX > 0)
                    anim.SetBool("Right", true);
                else
                    anim.SetBool("Left", true);
            }
            else
            {
                if (moveY > 0)
                    anim.SetBool("top", true);
                else
                    anim.SetBool("down", true);
            }
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * moveSpeed;
    }
}
