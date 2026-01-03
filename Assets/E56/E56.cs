using UnityEngine;

public class E56 : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float velocidad;

    [Header("Destroy in area")]
    [SerializeField] private float radioDestruccion = 3f;
    [SerializeField] private string tagDestruible = "Destructible";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            direccion.y = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direccion.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direccion.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direccion.x = 1;
        }

        transform.position = transform.position + direccion * velocidad * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DestruirObjetosCercanos();
        }
    }

    private void DestruirObjetosCercanos()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, radioDestruccion);

        foreach (Collider2D hit in hits)
        {
            if (hit.gameObject == gameObject) continue;

            if (hit.CompareTag(tagDestruible))
            {
                Destroy(hit.gameObject);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radioDestruccion);
    }
}

