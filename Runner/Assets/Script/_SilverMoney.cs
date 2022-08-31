using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _SilverMoney : MonoBehaviour
{
    public void OnTriggerEnter(Collider S)
    {
        if(S.tag == "Hose")
        {
            CoinScript.CoinAmount +=5;
            Destroy(gameObject);
        }

    }
}
