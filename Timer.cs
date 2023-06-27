using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TextMeshProUGUI coinsCounterText;

    void Update()
    {
        seconds -=Time.deltaTime;
        if (seconds <=0){
            if (minutes > 0){
                seconds +=59;
                minutes--;
            }
        }
        coinsCounterText.text = '0' + minutes.ToString() + ':' + Mathf.Round(seconds).ToString();
    }
}
