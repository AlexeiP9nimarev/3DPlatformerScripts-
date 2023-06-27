using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platfrom : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public bool isActive;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isActive) 
        {
            transform.position += direction*speed* Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other) {
        print(other.gameObject.tag);
        if (other.gameObject.tag == "StopPlatform")
        {
            direction *= -1;
        }
        if(other.gameObject.tag == "player")
        {
            isActive = true;
        }
    }
    // private void OnTriggerExit(Collider other) {
    //     if (other.gameObject.tag == "player")
    //     {
    //         isActive = false;
    //     }
    // }
}
