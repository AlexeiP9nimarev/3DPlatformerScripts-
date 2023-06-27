using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonFire : MonoBehaviour
{
    public float timeBonFire = 15f;
    public float heatPower = 0.1f;
    public bool isActiveFire = false;
    private void Start() {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActiveFire)
        {
            timeBonFire -=Time.deltaTime;
            if (timeBonFire <= 0 ) {
                gameObject.SetActive(false);
            }
        }
        
    }

    private void OnTriggerEnter(Collider other) {
        isActiveFire = true;
    }
    private void OnTriggerStay(Collider other) {
        
        if (other.GetComponent<Temperature>()){
            Temperature playerTemp = other.GetComponent<Temperature>();
        
            if (playerTemp.temperatureCurrent < playerTemp.temperatureNormal){
                playerTemp.temperatureCurrent+=heatPower*Time.deltaTime;
            }
        
        }
        
    }
}
