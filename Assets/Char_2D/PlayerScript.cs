using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerScript : MonoBehaviour
{
    public float MoveSpeed;
    public Rigidbody2D rb;
    public Animator animator;

    private bool isMovingLeft = false;
    private bool isMovingRight = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isMovingLeft)
        {
            rb.velocity = new Vector2(-MoveSpeed, 0f);
            transform.right = Vector2.left;
        }
        else if (isMovingRight)
        {
            rb.velocity = new Vector2(MoveSpeed, 0f);
            transform.right = Vector2.right;
        }


        if (Mathf.Abs(rb.velocity.x) > 0f)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }

    }

    public void MoveLeft()
    {
        isMovingLeft = true;
    }

    public void MoveRight()
    {
        isMovingRight = true;
    }

    public void StopMoving()
    {
        isMovingLeft = false;
        isMovingRight = false;
    }

}
