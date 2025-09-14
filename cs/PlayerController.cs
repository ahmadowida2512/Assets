using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    [SerializeField]

    float speed = 0.03f;
    // [SerializeField]
    // float Jump = 10f;
    public int hearts = 3;
    private Vector3 respawnPoint;
    public TMP_Text heartsText;
    Transform myTransform;
    SpriteRenderer mySprite;
    Rigidbody2D rb;

    void Start()
    {


    //     myTransform = GetComponent<Transform>();
    //     mySprite = GetComponent<SpriteRenderer>();
    //     rb = GetComponent<Rigidbody2D>();
    //         respawnPoint = transform.position; 

    //     UpdateHeartsUI();

    // }

    // void Update()
    // {
    //     if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
    //     {

    //         mySprite.flipX = true;
    //     }
    //     else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
    //     {

    //         mySprite.flipX = false;
    //     }



    //     rb.velocity = new Vector2(speed * Input.GetAxis("Horizontal") * Time.deltaTime, rb.velocity.y);
    //     mySprite.flipX = (Input.GetAxis("Horizontal") < -0.01f);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.CompareTag("Collectible"))
{
    respawnPoint = other.transform.position; // خزن الموقع
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
        // إعادة تحميل نفس المستوى الحالي
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
    else
    {
        Respawn();
    }
}

    void Respawn()
    {
        if (respawnPoint != null)
        {
    transform.position = respawnPoint;
    rb.velocity = Vector2.zero;
        }
    }

    void UpdateHeartsUI()
    {
        heartsText.text = ": " + hearts;
    }
}

