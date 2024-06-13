using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private GameObject player;
    public float jumpForce = 10f; // scale at which the players position will update  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();            
            if (rb != null)
            {
                if(rb != null){
                    Vector2 velocity = rb.velocity;
                    velocity.y = jumpForce;
                    rb.velocity = velocity; //when player touches platform it launches them into the air
                }
            }

        }
    }

    // private void OnCollusionEnter(Collision2D collision)
    // {
    //     if (collision.gameObject.tag == ("Edge"))
    //     {
    //         Destroy(gameObject);
    //     }
    // }
    void Start() 
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        DestroyOutOfBounds(); //delete if out of bounds
        //check if off screen and delete if yas 
    }

       public void DestroyOutOfBounds() 
        {
            Debug.Log(gameObject.transform.position.y);
            Debug.Log(player.transform.position.y);
        if (gameObject.transform.position.y > (player.transform.position.y + 50))
        {
            Destroy(gameObject);
            Debug.Log("deleted object!");
        }
  
    }

}

