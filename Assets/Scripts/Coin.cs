using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (!col.CompareTag("Player"))
        {
            return;
        }
        ++col.gameObject.GetComponent<PlayerController>().CoinsCollected;
        --col.gameObject.GetComponent<PlayerController>().CoinsToCollect;
        Destroy(gameObject);
    }
}
