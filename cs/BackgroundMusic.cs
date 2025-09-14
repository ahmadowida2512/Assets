using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // يبقي الكائن عند تحميل مشاهد جديدة
        }
        else
        {
            Destroy(gameObject); // منع تكرار الصوت عند إعادة المشهد أو الدخول من جديد
        }
    }
}
