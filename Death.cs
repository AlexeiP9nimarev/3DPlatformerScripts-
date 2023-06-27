using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject spawn;
    // Start is called before the first frame update
    SpeedTrigger death;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "player")
        {
            
            collision.transform.position = spawn.transform.position;
        }
    }

}
