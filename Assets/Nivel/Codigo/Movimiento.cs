using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D _rigidbody;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        var movimiento = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movimiento, 0, 0) * Time.deltaTime * speed;

        // Voltear el sprite si el movimiento es hacia la izquierda
        if (movimiento < 0)
        {
            _spriteRenderer.flipX = true;
        }
        else if (movimiento > 0)
        {
            _spriteRenderer.flipX = false;
        }

        // Cambiar la animación según el estado de movimiento
        if (Mathf.Abs(movimiento) > 0)
        {
            _animator.SetBool("Corre", true);
        }
        else
        {
            _animator.SetBool("Corre", false);
        }
    }
}
