using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private GameObject player;
    private Camera cameraSense; // for delete
    public float jumpForce = 11f; // scale at which the players position will update  
    
    //for pltform movement 
    //private Vector3 startPosition;
    //private float frequency = Random.Range(1f, 4f);
    //private float magnitude = 2f; 
    //private float offset = 0f; 
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

    void Awake() //when loading
    {
        cameraSense = Camera.main;
    }

    void Start() 
    {
        player = GameObject.Find("Player");
        //startPosition = transform.position;
    }

    void Update()
    {
        //transform.position.x = startPosition + transform.right*Mathf.Sin(Time.time *frequency + offset) * magnitude;
        // DestroyOutOfBounds(); //delete if out of bounds
        //check if off screen and delete if yas 
    }

        // Vector2 screenPosition = cameraSense.WorldToScreenPoint(transform.position);
        // if (screenPosition.y <0)
        // {
        //     Destroy(gameObject);
        // }
  
    

}

