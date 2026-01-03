using UnityEngine;

public class E57 : MonoBehaviour
{
    [SerializeField] private float velocidad = 5f;

    [SerializeField] private float radioExplosion = 3f;
    [SerializeField] private float fuerzaExplosion = 20f;

    private Rigidbody2D rb;
    private Vector2 input;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        float x = 0f;
        float y = 0f;

        if (Input.GetKey(KeyCode.A)) x = -1f;
        if (Input.GetKey(KeyCode.D)) x = 1f;
        if (Input.GetKey(KeyCode.S)) y = -1f;
        if (Input.GetKey(KeyCode.W)) y = 1f;

        input = new Vector2(x, y).normalized;

       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Explode();
        }
    }

    void FixedUpdate()
    {
        
        rb.MovePosition(rb.position + input * velocidad * Time.fixedDeltaTime);
    }

    private void Explode()
    {
        Vector2 posicion = rb.position;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(posicion, radioExplosion);

        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody2D body = colliders[i].attachedRigidbody;
            if (body == null) continue;
            if (body == rb) continue;

            Vector2 dir = (body.position - posicion).normalized;
            body.AddForce(dir * fuerzaExplosion, ForceMode2D.Impulse);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radioExplosion);
    }
}

