using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTime : MonoBehaviour
{
    public float startingHour = 0f;
    public float startingMinute = 0f;
    public bool stopTime = false;
    float currentHour;
    float currentMinute;
    float Minute = 0.333333333f;


    public TextMesh countDownTime;    

    // Start is called before the first frame update
    void Start()
    {
        currentHour = startingHour; 
        currentMinute = startingMinute;
    }

    // Update is called once per frame
    void Update()
    {
        if (!stopTime) {
            currentMinute += Time.deltaTime / Minute;
            if (currentMinute > 59)
            {
                currentMinute = 0;
                currentHour += 1;
            }
            if (currentHour > 23)
            {
                currentHour = 0;
            }
        }
        countDownTime.text = currentHour.ToString("00") + ":" + currentMinute.ToString("00");
    }

    public void setState(bool state)
    {
        stopTime = state;
    }

    public float getCurrentHour()
    {
        return currentHour;
    }
}
