using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimientoX = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(
            movimientoX * velocidad,
            rb.linearVelocity.y
        );
    }
}