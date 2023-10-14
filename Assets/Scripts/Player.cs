using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public SpawnCoin sCoin;


    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>())
        {
            sCoin.CollectCoin((other.GetComponent<Coin>()));
        }
    }

}
