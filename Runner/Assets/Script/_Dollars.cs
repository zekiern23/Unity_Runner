using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Dollars : MonoBehaviour
{
        public void OnTriggerEnter(Collider Dol)
    {
        if(Dol.tag == "Hose")
        {
            CoinScript.CoinAmount +=1;
            Destroy(gameObject);
        }

    }
}
