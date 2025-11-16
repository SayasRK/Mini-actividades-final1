using UnityEngine;

public class E26 : MonoBehaviour
{
    public float salto = 5f;
    private Rigidbody2D rb; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            rb.AddForce(Vector2.up * salto, ForceMode2D.Impulse);
        }    
    }
}

//Si presiono el espacio la caja salta usando la fuerza fisica
