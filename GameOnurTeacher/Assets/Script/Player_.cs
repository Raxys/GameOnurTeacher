using UnityEngine;

public class Simple2DMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float sprintMultiplier = 1.5f;  // Shift’le ne kadar hızlanacağı
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

        moveInput = new Vector2(moveX, moveY).normalized;

        // Animasyonları sıfırla
        anim.SetBool("Right", false);
        anim.SetBool("Left", false);
        anim.SetBool("top", false);
        anim.SetBool("down", false);

        if (moveInput != Vector2.zero)
        {
            if (Mathf.Abs(moveX) > Mathf.Abs(moveY))
                anim.SetBool(moveX > 0 ? "Right" : "Left", true);
            else
                anim.SetBool(moveY > 0 ? "top" : "down", true);
        }
    }

    void FixedUpdate()
    {
        // Shift'e basılıysa sprintMultiplier kadar hızlan
        float speed = moveSpeed * (Input.GetKey(KeyCode.LeftShift) ? sprintMultiplier : 1f);
        rb.linearVelocity = moveInput * speed;
    }
}
