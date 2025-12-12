using UnityEngine;

public class Seguidor1 : MonoBehaviour
{
    [SerializeField] private Transform objetivo;
    [SerializeField] private float maxSpeed = 3f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()

    {
        if (objetivo == null) return;

        Vector2 pos = rb.position;
        Vector2 targetPos = objetivo.position;

        Vector2 direction = (targetPos - pos).normalized;

        
        float desiredX = direction.x * maxSpeed;

       
        rb.linearVelocityX = desiredX;
    }
}
