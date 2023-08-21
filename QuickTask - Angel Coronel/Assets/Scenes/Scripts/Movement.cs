using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private float moveSpeed;
    private float jumpforce;
    private float isJumping;
    private float moveHorizontal;
    private float moveVertical;

    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();

        moveSpeed = 3f;
        jumpforce = 60f;
        isJumping = false;
    }

    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if(moveHorizontal > 0.1f  moveHorizontal < -0.1f)
        {
            rb2D.AddForce
        }
    }
}
