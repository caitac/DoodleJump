using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb; 
    private float moveX; 

    private Camera cameraSense; 

    // Start is called before the first frame update
    void Awake() //when loading
    {
        rb = GetComponent<Rigidbody2D>();
        cameraSense = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed; //moves the position by factor of the move speed
    }

    private void PlayerDies()
    {

    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity; //updates everything
        velocity.x = moveX;
        rb. velocity = velocity;

        Vector2 screenPosition = cameraSense.WorldToScreenPoint(transform.position);
        if (screenPosition.y <0)
        {
            PlayerDies();
        }
    }
}
