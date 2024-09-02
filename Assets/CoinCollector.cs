using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public Text coinText; // 코인 수를 표시할 텍스트
    private int totalCoins = 5; // 총 코인 수
    private int collectedCoins = 0; // 수집된 코인 수

    void Start()
    {
        UpdateCoinText();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            collectedCoins++;
            Destroy(other.gameObject); // 코인 오브젝트 삭제
            UpdateCoinText();
        }
    }

    void UpdateCoinText()
    {
        coinText.text = collectedCoins.ToString() + "/" + totalCoins.ToString() + " (coin)";
    }
}
