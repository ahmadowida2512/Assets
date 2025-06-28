using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectFlower : MonoBehaviour
{
    public int flowerCount = 0;
public TMP_Text flowerText;

    private void Start()
    {
        UpdateFlowerUI();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            flowerCount++;
            UpdateFlowerUI();
        }
    }

    void UpdateFlowerUI()
    {
        flowerText.text = ": " + flowerCount.ToString();
    }
}
