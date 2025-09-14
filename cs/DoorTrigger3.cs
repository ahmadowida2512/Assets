using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTrigger3 : MonoBehaviour
{
    public string Level_one; // اسم المشهد الجديد

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("finallevel"); // أو استخدم Level_one بدلًا من كتابة الاسم مباشرة
        }
    }
}
