using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    int playerSpeed = 10;
    Rigidbody2D rb;

    float jumpForce = 10f;
    bool isGrounded;

    bool crouching;

    bool sprinting;

    float slideSpeed = 20;
    bool sliding;

    public GameObject stand;
    public GameObject crouch;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(playerSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-playerSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        if (Input.GetKey(KeyCode.LeftShift) && !crouching && !sliding)
        {
            sprinting = true;
            playerSpeed = 20;
        }
        else
        {
            sprinting = false;
            playerSpeed = 10;
        }

        if (Input.GetKey(KeyCode.C) && Input.GetKey(KeyCode.LeftShift))
        {
            crouch.SetActive(true);
            stand.SetActive(false);
            transform.position = transform.position + new Vector3(slideSpeed * Time.deltaTime, 0, 0);
            sliding = true;
        }
        else if (Input.GetKey(KeyCode.C))
        {
            crouch.SetActive(true);
            stand.SetActive(false);
            crouching = true;
        }
        else
        {
            crouch.SetActive(false);
            stand.SetActive(true);
            sliding = false;
            crouching = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //checking if the player is touching the ground, using a tag defined in the editor
        if (collision.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        //checking if the player is touching the ground, using a tag defined in the editor
        if (collision.gameObject.CompareTag("Floor"))
        {
            isGrounded = false;
        }
    }
}
