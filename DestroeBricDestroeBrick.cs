using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroeBricDestroeBrick : MonoBehaviour
{
    private float speed=2f;
    public Transform target;
    public float playerDamage=2f;
    public float healthEnemy = 5f; 
    public AudioClip shotSFX;
    public AudioSource _audioSource;

    void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed*Time.deltaTime);
        transform.LookAt(target.transform.position);
       
    }
    // private void OnCollisionEnter(Collision collision) 
    // {
    //     Player2 player= collision.gameObject.GetComponent<Player2>();
    //     Rigidbody rigidbody = collision.gameObject.GetComponent<Rigidbody>();
    //     if (collision.gameObject.tag == "player")
        
    //     {
    //         rigidbody.useGravity = false;
    //         player.TakeDamage(playerDamage);
    //         _audioSource.Play();
    //         Destroy(gameObject);
    //     }
        
    // }
        private void OnCollisionEnter(Collision collision) 
    {
        Health player= collision.gameObject.GetComponent<Health>();
        if (collision.gameObject.tag == "player")
        
        {
            player.TakeDamage(playerDamage);
        }
        
    }
    public void TakeDamageHealth(float damage) {
        healthEnemy-=damage;
        print("Отсалось здоровья у Enemy " + healthEnemy);
    }
}
