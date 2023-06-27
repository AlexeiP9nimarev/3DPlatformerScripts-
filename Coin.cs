using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    // private void OnTriggerEnter(Collider other) {
    //     if (other.gameObject.tag == "player")
    //     {
    //         Player2 player = other.GetComponent<Player2>();
    //         player.CollestCoins();
    //         Destroy(gameObject);
    //     }
        
    // }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "player")
        {
            CoinsCounter player = other.GetComponent<CoinsCounter>();
            player.CollestCoins();
            Destroy(gameObject);
        }
        
    }
}
