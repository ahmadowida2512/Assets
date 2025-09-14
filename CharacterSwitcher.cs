using UnityEngine;

public class CharacterSwitcher : MonoBehaviour
{
    public GameObject characterToShow;            // الشخصية اللي رح تظهر
    public GameObject[] allCharacters;            // كل الشخصيات عشان نخفيهم

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // إخفاء كل الشخصيات
            foreach (GameObject character in allCharacters)
            {
                character.SetActive(false);
            }

            // إظهار الشخصية المرتبطة بهذا الأبجكت
            if (characterToShow != null)
            {
                characterToShow.SetActive(true);
            }
        }
    }
}
