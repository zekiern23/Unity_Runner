using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Emerland : MonoBehaviour
{
    public void OnTriggerEnter(Collider E)
    {
        if(E.tag == "Hose")
        {
            CoinScript.CoinAmount +=100;
            Destroy(gameObject);
        }

    }
}
