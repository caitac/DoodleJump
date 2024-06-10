using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb; 

    private float moveX; 
    // Start is called before the first frame update
    void Awake() //when loading
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed; //moves the position by factor of the move speed
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity; //updates everything
        velocity.x = moveX;
        rb. velocity = velocity;
    }
}
