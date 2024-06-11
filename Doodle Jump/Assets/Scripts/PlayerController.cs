using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb; 
    private float moveX; 
    private Camera cameraSense;

    //move back and forth tehehe
    private bool isFacingRight;
    private bool isFacingLeft;

    private Vector2 facingRight;
    private Vector2 facingLeft; 

    // Start is called before the first frame update
    void Awake() //when loading
    {
        rb = GetComponent<Rigidbody2D>();
        cameraSense = Camera.main;

        //moving back and forth
        facingLeft = new Vector2(-transform.localScale.x, transform.localScale.y);
        facingRight = new Vector2(transform.localScale.x, transformScale.y);
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

        if(velocity.x < 0)
        {
            isFacingRight = false;
            isFacingLeft = true;
        }
        else{
            
        }

        //THIS IS FOR DEATH
        Vector2 screenPosition = cameraSense.WorldToScreenPoint(transform.position);
        if (screenPosition.y <0)
        {
            PlayerDies();
        }

    }

    private void PlayerDies()
    {
        Debug.Log("end screen loading");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}

