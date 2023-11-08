using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum Size
{
    small=0, large=1, huge=2
}
public class CharacterController : MonoBehaviour
{   //Movement
    //public event EventHandler OnSizeChanged;
    [SerializeField]  private Size size=Size.large;
    [SerializeField] private float speed;
    [SerializeField] private float jump;
    float moveVelocity;

    //Grounded Vars
    bool isGrounded = true;

    void Update()
    {
        //Jumping
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W))
        {
            if (isGrounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
                isGrounded = false;
            }
        }

        moveVelocity = 0;

        //Left Right Movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

    }
    public void IncreaseSize()
    {
        size++;
        transform.localScale *= 2;
    }
    public void DecreaseSize()
    {
        size--;
        transform.localScale /= 2;
    }
    //Check if Grounded
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        isGrounded = true;
    }
    void OnCollisionExit2D(Collision2D col)
    {
        Debug.Log("OnCollisionExit2D");
        isGrounded = false;
    }
    public Size GetSize()
    {
        return size;
    }
}
