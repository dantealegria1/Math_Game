using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_malos : MonoBehaviour
{
    public float speed = 10f; // Velocidad de movimiento
    public float radius = 15f; // Radio de movimiento
    public float rotationSpeed = 1f; // Velocidad de rotación

    private float angle = 0f;
    private Vector3 centerPosition;
    private bool isMovingLeft = false;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        centerPosition = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Calcular la nueva posición alrededor del eje X
        float x = centerPosition.x + Mathf.Cos(angle) * radius;
        float y = transform.position.y;
        float z = transform.position.z;

        // Actualizar la posición del objeto
        transform.position = new Vector3(x, y, z);

        // Girar el sprite si el movimiento es hacia la izquierda
        if (Mathf.Cos(angle) < 0 && !isMovingLeft)
        {
            isMovingLeft = true;
            spriteRenderer.flipX = true;
        }
        else if (Mathf.Cos(angle) >= 0 && isMovingLeft)
        {
            isMovingLeft = false;
            spriteRenderer.flipX = false;
        }

        // Incrementar el ángulo para el próximo frame
        angle += rotationSpeed * Time.deltaTime;

        // Asegurarse de que el ángulo esté dentro del rango [0, 360]
        if (angle >= 360f)
        {
            angle -= 360f;
        }
    }
}
