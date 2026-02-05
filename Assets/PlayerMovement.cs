using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        //Tracks the player's movement keys
        rb = GetComponent<Rigidbody2D>();
        float moveX = Input.GetAxis("Horizontal");    
        float moveY = Input.GetAxis("Vertical"); 

        //Saves the player's movement keys into variables
        Vector2 moveDirection = new Vector2 (moveX, moveY);

        //Used to smooth the speed, needs fixing
        if(moveDirection.magnitude > 0)
        {
            rb.linearVelocity = moveDirection.normalized*speed;
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    
    }
    
}
