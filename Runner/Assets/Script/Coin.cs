using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
        public void OnTriggerEnter(Collider C)
    {
        if(C.tag == "Hose")
        {
            CoinScript.CoinAmount +=10;
            Destroy(gameObject);
        }

    }
}
