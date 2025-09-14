using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int hearts = 3;
    private Vector3 lastSafePosition;

    void Start()
    {
        // حفظ موقع البداية كنقطة آمنة
        lastSafePosition = transform.position;
    }

    void Update()
    {
        // مثال: إذا ضغط اللاعب على مفتاح معين نحفظ موقعه الحالي كنقطة آمنة
        if (Input.GetKeyDown(KeyCode.P))
        {
            lastSafePosition = transform.position;
            Debug.Log("تم حفظ النقطة الآمنة");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            hearts--;
            Debug.Log("تم لمس الأرضية (Trigger)! القلوب المتبقية: " + hearts);
            transform.position = lastSafePosition;
        }
    }

}
