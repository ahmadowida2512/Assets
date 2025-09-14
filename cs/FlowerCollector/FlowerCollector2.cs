using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FlowerCollector2 : MonoBehaviour
{
    public int flowerCount = 0;
    public int requiredFlowers = 3;
public TMP_Text flowerText;

    public GameObject elixirUI;     // UI: إشعار الترياق
    public GameObject elixirObject; // GameObject: الترياق الفعلي

    private bool elixirUnlocked = false;

    void Start()
    {
        UpdateFlowerUI();
        if (elixirUI != null) elixirUI.SetActive(false);
        if (elixirObject != null) elixirObject.SetActive(false);
         UpdateFlowerUI();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            flowerCount++;
           
            UpdateFlowerUI();
            CheckElixirUnlock();
        }
        // if (other.CompareTag("Flower"))
        // {
        //     flowerCount++;
        //     Destroy(other.gameObject);
        //     UpdateFlowerUI();
        //     CheckElixirUnlock();
        // }
    }

    void CheckElixirUnlock()
    {
        if (!elixirUnlocked && flowerCount >= requiredFlowers)
        {
            elixirUnlocked = true;
            if (elixirUI != null) elixirUI.SetActive(true);
            if (elixirObject != null) elixirObject.SetActive(true);
        }
    }

    void UpdateFlowerUI()
    {
        if (flowerText != null)
            flowerText.text = ": " + flowerCount.ToString();
                    

    }
}
