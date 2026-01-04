using UnityEngine;

public class E64 : MonoBehaviour
{
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private GameObject circulo;

    private Rigidbody2D rb;
    private Vector2 input;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
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
            Instantiate(circulo, transform.position, Quaternion.identity);
            audioSource.Play();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + input * velocidad * Time.fixedDeltaTime);
    }
}
