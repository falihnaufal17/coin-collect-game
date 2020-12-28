using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public int CoinsToCollect = 0;
    public int CoinsCollected = 0;
    public Text UIText = null;
    public GameObject WinText = null;

    public GameObject WinPrefab = null;

    // Start is called before the first frame update
    void Awake()
    {
        CoinsToCollect = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    // Update is called once per frame
    void Update()
    {
        UIText.text = "Coins: " + CoinsToCollect + " Remaining";

        if (CoinsCollected >= CoinsToCollect)
        {
            // Game Win
            WinPrefab.SetActive(true);
            WinText.SetActive(true);
        }
    }
}
