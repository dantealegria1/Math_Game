using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saltar : MonoBehaviour
{
    public float jumpForce = 10f; // The force of the jump
    private bool isGrounded; // Whether or not the character is on the ground
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, jumpForce);
            isGrounded = false;
            _animator.SetBool("Salta", true);
        }
        else
        {
            _animator.SetBool("Salta", false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}

