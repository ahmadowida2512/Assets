using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController1 : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 7f;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Transform groundCheck;

    public int hearts = 3;
    private Vector3 respawnPoint;
    public TMP_Text heartsText;

    Transform myTransform;
    SpriteRenderer mySprite;
    Rigidbody2D rb;

    private bool isGrounded;
    private float tiltAngle = 15f;

    void Start()
    {
        myTransform = GetComponent<Transform>();
        mySprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
        UpdateHeartsUI();
    }

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        bool jump = Input.GetButtonDown("Jump");

        // Flip الشخصية حسب الاتجاه
        if (move < 0)
            mySprite.flipX = true;
        else if (move > 0)
            mySprite.flipX = false;

        // تحديث السرعة
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        // القفز
        if (jump && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // الميلان أثناء القفز
        if (!IsGrounded())
        {
            if (move > 0)
                transform.rotation = Quaternion.Euler(0, 0, -tiltAngle);
            else if (move < 0)
                transform.rotation = Quaternion.Euler(0, 0, tiltAngle);
        }
        else
        {
            // إعادة التوازن عند الهبوط
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private bool IsGrounded()
    {
        // دائرية صغيرة أسفل اللاعب
        return Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            respawnPoint = other.transform.position;
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Trap"))
        {
            LoseHeart();
        }
    }

    void LoseHeart()
    {
        hearts--;
        UpdateHeartsUI();

        if (hearts <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = respawnPoint;
        rb.velocity = Vector2.zero;
    }

    void UpdateHeartsUI()
    {
        heartsText.text = ": " + hearts;
    }
}
