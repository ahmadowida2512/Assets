using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class FancyMovement : MonoBehaviour
{
    // [Header("Movement")]
    public float moveSpeed = 8f;
    public float acceleration = 0.1f;

    // private float moveInput;
    // private float currentSpeed;
    // private float velocitySmoothing;
    //    public int hearts = 3;
    // private Vector3 respawnPoint;
    // public TMP_Text heartsText;

    // [Header("References")]
    // private Rigidbody2D rb;
    // private SpriteRenderer sr;
    // private Animator animator; // لو عندك أنيميشن

    // [Header("Visual Tilt (Optional)")]
    // public float tiltAmount = 10f;

    void Start()
    {
        // rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        // animator = GetComponent<Animator>(); // لو ما عندك، احذف هذا السطر
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        // Flip حسب الاتجاه
        if (moveInput != 0)
            sr.flipX = moveInput < 0;

        // // الميلان الجمالي
        // float tiltZ = -moveInput * tiltAmount;
        // transform.rotation = Quaternion.Euler(0f, 0f, tiltZ);

        // تحريك الأنيميشن (لو موجود)
        if (animator != null)
        {
            animator.SetFloat("Speed", Mathf.Abs(moveInput));
        }
    }

//     void FixedUpdate()
//     {
//         // حركة سلسة
//         float targetSpeed = moveInput * moveSpeed;
//         currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref velocitySmoothing, acceleration);

//         rb.velocity = new Vector2(currentSpeed, rb.velocity.y);
//     }
//         private void OnTriggerEnter2D(Collider2D other)
//     {
//        if (other.CompareTag("Collectible"))
// {
//     respawnPoint = other.transform.position; // خزن الموقع
//     Destroy(other.gameObject);
// }

//         else if (other.CompareTag("Trap"))
//         {
//             LoseHeart();
//         }
//     }
// void LoseHeart()
// {
//     hearts--;
//     UpdateHeartsUI();

//     if (hearts <= 0)
//     {
//         // إعادة تحميل نفس المستوى الحالي
//         string currentScene = SceneManager.GetActiveScene().name;
//         SceneManager.LoadScene(currentScene);
//     }
//     else
//     {
//         Respawn();
//     }
// }

//     void Respawn()
//     {
//         if (respawnPoint != null)
//         {
//     transform.position = respawnPoint;
//     rb.velocity = Vector2.zero;
//         }
//     }

//     void UpdateHeartsUI()
//     {
//         heartsText.text = ": " + hearts;
//     }
}
