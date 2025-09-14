using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalTrigger : MonoBehaviour
{
    public float cameraMoveDistance = 3f;       // مقدار صعود الكاميرا للأعلى
    public float delayBeforeSceneLoad = 2f;     // الانتظار قبل تحميل المشهد الجديد
    public string nextSceneName = "Level2";     // اسم المشهد الجديد

    private bool triggered = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!triggered && other.CompareTag("Player"))
        {
            triggered = true;
            StartCoroutine(HandleFinalSequence());
        }
    }

    IEnumerator HandleFinalSequence()
    {
        // تحريك الكاميرا للأعلى
        Transform cam = Camera.main.transform;
        Vector3 startPos = cam.position;
        Vector3 targetPos = startPos + new Vector3(0, cameraMoveDistance, 0);
        float duration = 1f;
        float t = 0;

        while (t < 1)
        {
            t += Time.deltaTime / duration;
            cam.position = Vector3.Lerp(startPos, targetPos, t);
            yield return null;
        }

        // الانتظار ثم تحميل المشهد
        yield return new WaitForSeconds(delayBeforeSceneLoad);
        SceneManager.LoadScene("finallevel1");
    }
}
