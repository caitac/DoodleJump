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

    public bool isFacingRight;
    public bool spawnFacingRight;
    private Vector2 facingLeft; 

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

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity; //updates everything
        velocity.x = moveX;
        rb. velocity = velocity;
        if (velocity < 0)
        {
            //animation
        }
        else
        {
            //animation
        }

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

