using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    Text Cointext;
    public static int CoinAmount;
    void Start()
    {
        Cointext= GetComponent<Text>();
    }

    void Update()
    {
        Cointext.text= CoinAmount.ToString();
    }
}
