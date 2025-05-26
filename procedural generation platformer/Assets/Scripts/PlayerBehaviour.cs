using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    int playerSpeed = 10;
    Rigidbody2D rb;

    bool facingRight = true;

    float jumpForce = 12f;
    bool isGrounded = true;
    public float groundCheckDistance = 1.1f;
    public LayerMask groundLayer;

    bool crouching;
    public GameObject stand;
    public GameObject crouch;

    float slideForce = 12f;
    bool sliding = false;

    float rollXForce = 20f;
    float rollYForce = 6f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(playerSpeed * Time.deltaTime, 0, 0);
            facingRight = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-playerSpeed * Time.deltaTime, 0, 0);
            facingRight = false;
        }

        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && !crouching)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && isGrounded && crouching)
        {
            StartCoroutine(Roll());
        }

        if (Input.GetKey(KeyCode.LeftShift) && !crouching)
        {
            playerSpeed = 20;
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift) && crouching && !sliding)
        {
            StartCoroutine(Sliding());
        }
        else
        {
            playerSpeed = 10;
        }

        if (Input.GetKey(KeyCode.C))
        {
            crouch.SetActive(true);
            stand.SetActive(false);
            crouching = true;
        }
        else
        {
            crouch.SetActive(false);
            stand.SetActive(true);
            crouching = false;
        }
    }

    IEnumerator Sliding()
    {
        if (facingRight)
        {
            rb.velocity = new Vector2(slideForce, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(-slideForce, rb.velocity.y);
        }
        sliding = true;

        yield return new WaitForSeconds(0.8f);

        rb.velocity = new Vector2(0, 0);
        sliding = false;
    }

    IEnumerator Roll()
    {
        if (facingRight)
        {
            rb.velocity = new Vector2(rollXForce, rollYForce);
        }
        else
        {
            rb.velocity = new Vector2(-rollXForce, rollYForce);
        }

        yield return new WaitForSeconds(0.6f);

        rb.velocity = new Vector2(0, 0);
    }
}
