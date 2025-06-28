using UnityEngine;

public class AutoJumpPad : MonoBehaviour
{
    public float jumpForce = 12f; // قوة النطة
    public string playerTag = "Player"; // لازم اللاعب يكون إله tag = Player

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }
    }
}
