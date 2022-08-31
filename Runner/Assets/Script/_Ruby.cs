using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Ruby : MonoBehaviour
{
        public void OnTriggerEnter(Collider R)
    {
        if(R.tag == "Hose")
        {
            CoinScript.CoinAmount +=50;
            Destroy(gameObject);
        }

    }
}
