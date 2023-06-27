using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TemperatureUi : MonoBehaviour
{
    public Temperature temperaturePlayer;
    // public Slider thermometer;
    public TextMeshProUGUI text;

    // Update is called once per frame
    void Update()
    {
        text.text = temperaturePlayer.temperatureCurrent.ToString();
    }
}
