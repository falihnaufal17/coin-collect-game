using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class TimeOut : MonoBehaviour
{
    public float TotalTime = 60f;
    private PlayerController PC = null;
    public Text UIText = null;

    private float TimeElapsed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        PC = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        //Invoke("Restart", TotalTime);
    }

    void Update()
    {
        TimeElapsed += Time.deltaTime;

        UIText.text = (Mathf.RoundToInt(TotalTime - TimeElapsed)).ToString();

        if(TimeElapsed >= TotalTime)
        {
            Restart();
        }
    }

    public void Restart()
    {
        if(PC.CoinsCollected < PC.CoinsToCollect)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
