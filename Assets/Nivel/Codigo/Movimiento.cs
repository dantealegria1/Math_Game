using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var movimiento = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movimiento, 0, 0) * Time.deltaTime * speed;


    }

}
