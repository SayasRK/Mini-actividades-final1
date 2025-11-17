using UnityEngine;

public class E31 : MonoBehaviour
{
    [SerializeField] private float velocidad;

    private SpriteRenderer color;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        color = GetComponent<SpriteRenderer>();
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
    }

    
    
    void OnTriggerEnter2D(Collider2D collision)
    {
     color.color = Color.red;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
     color.color = Color.white;
    }
}

//Uso SpriteRenderer para cambiar el color

