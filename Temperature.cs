using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public float temperatureCurrent=36.6f;
    public float temperatureNormal=36.6f;
    public float temperatureCritica=34f;
    public float freezeSpeed= 0.05f;
    public int playerDamage = 2;
    public Health healthPlayer;
    public float delay = 0;

    // Update is called once per frame
    private void Update()
    {
        temperatureCurrent -= freezeSpeed*Time.deltaTime;
        if (temperatureCurrent <= temperatureCritica)
        {
            if (delay <= 0)
            {
                healthPlayer.TakeDamage(playerDamage);
                delay = 2f;
                print(healthPlayer);
            }
            
            delay-=Time.deltaTime;
        }
    }
}
