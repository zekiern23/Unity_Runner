using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Diamond : MonoBehaviour
{
        public void OnTriggerEnter(Collider D)
    {
        if(D.tag == "Hose")
        {
            CoinScript.CoinAmount +=25;
            Destroy(gameObject);
        }

    }
}
