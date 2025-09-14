using UnityEngine;
using UnityEngine.UI;

public class EndingManager : MonoBehaviour
{
    public GameObject decisionPanel;    // تظهر عند الوصول للنهاية
    public GameObject goodEndingPanel;  // نهاية جيدة
    public GameObject badEndingPanel;   // نهاية حزينة

    public AudioSource goodEndingSound;
    public AudioSource badEndingSound;

    void Start()
    {
        decisionPanel.SetActive(false);
        goodEndingPanel.SetActive(false);
        badEndingPanel.SetActive(false);
    }

    // تُستدعى عند دخول اللاعب لمنطقة النهاية
    public void ShowDecision()
    {
        decisionPanel.SetActive(true);
        Time.timeScale = 0f; // توقيف اللعبة مؤقتًا
    }

    // الزر: تحرير الوحش
    public void FreeTheBeast()
    {
        decisionPanel.SetActive(false);
        goodEndingPanel.SetActive(true);
        Time.timeScale = 0f;

        if (goodEndingSound != null)
            goodEndingSound.Play();
    }

    // الزر: حبسه مجددًا
    public void ImprisonTheBeast()
    {
        decisionPanel.SetActive(false);
        badEndingPanel.SetActive(true);
        Time.timeScale = 0f;

        if (badEndingSound != null)
            badEndingSound.Play();
    }

    // زر "خروج" بعد النهاية
    public void RestartGame()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0); // إعادة أول مشهد
    }
}
