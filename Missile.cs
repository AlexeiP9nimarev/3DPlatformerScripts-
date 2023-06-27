using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{

    public float speed=4f;
    public float damage = 2;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 3);
        transform.position +=transform.forward*speed*Time.deltaTime;
    
    }

    private void OnTriggerEnter(Collider other) {
        DestroeBricDestroeBrick enemy = other.GetComponent<DestroeBricDestroeBrick>();
        if (enemy){
            
            enemy.TakeDamageHealth(damage);
            if (enemy.healthEnemy <= 0){
                Destroy(enemy.gameObject);
            }
            Destroy(gameObject);
            
        }
        
        
    }
}
