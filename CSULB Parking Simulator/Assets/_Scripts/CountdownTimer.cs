using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {

    float timeLeft = 30;
    public Text timeDisplay;
    public GameObject lossText;
    string timeText;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            lossText.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
           timeText = timeLeft.ToString("F2");
           timeDisplay.text = timeText;
        }
    }

}
