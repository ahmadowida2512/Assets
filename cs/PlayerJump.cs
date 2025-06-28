using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 10f;             // قوة النطة
    public Transform groundCheck;             // نقطة فحص الأرض
    public float groundCheckRadius = 0.2f;    // نصف قطر الفحص
    public LayerMask groundLayer;             // طبقة الأرض

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // فحص إذا واقف على الأرض
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // نط لما يضغط زر القفز
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
