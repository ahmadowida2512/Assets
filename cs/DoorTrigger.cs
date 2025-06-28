using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class DoorTrigger : MonoBehaviour
{
    public string Level_one; // اسم المشهد الجديد

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level_2");
        }
    }
}
