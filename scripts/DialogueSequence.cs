using System.Collections;
using UnityEngine;
using TMPro;

public class DialogueSequence : MonoBehaviour
{
    public GameObject panel;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    void Start()
    {
        panel.SetActive(false);
        StartCoroutine(ShowTexts());
    }

    IEnumerator ShowTexts()
    {

        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);


        panel.SetActive(true);


        text1.gameObject.SetActive(true);
        yield return new WaitForSeconds(4f);
        text1.gameObject.SetActive(false);


        text2.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        text2.gameObject.SetActive(false);

        text3.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        text3.gameObject.SetActive(false);


        panel.SetActive(false);
    }
}
