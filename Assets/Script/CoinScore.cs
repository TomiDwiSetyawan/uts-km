using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    public static int hitungCoin;
    Text hitungCoinText;
    void Start()
    {
        hitungCoin = 0;
        hitungCoinText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hitungCoinText.text = hitungCoin.ToString();

    }
}
