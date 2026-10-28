using TMPro;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    public int coins = 0;
    public int val = 1;
    public int vVal = 5;
    public int lVal = 25;
    public TMP_Text coinText;
    private void Start()
    {
        coinText.text = "Coins: " + coins;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Valuable")
        {
            coins += val;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "VeryValuable")
        {
            coins += vVal;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "LegendaryValue")
        {
            coins += lVal;
            Destroy(collision.gameObject);
        }
    }
    public void Update()
    {
        coinText.text = "Coins: " + coins;
    }
}
