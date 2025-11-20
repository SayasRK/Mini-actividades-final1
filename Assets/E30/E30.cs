using UnityEngine;

public class E30 : MonoBehaviour
{
    [SerializeField] private float velocidad;

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
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entras");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Sales");
    }
}

//Mismo codigo de movimiento de ej anteriores
//Cuando entra o sale dentro del circulo sale el mensaje en consola
//importante marcar la casilla de "is trigger" para poder entrar y salir del circulo y que de esa manera pueda aparecer el mensaje en la consola