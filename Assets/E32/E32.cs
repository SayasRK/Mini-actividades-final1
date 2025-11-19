using UnityEngine;

public class E32 : MonoBehaviour
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        //para cuando entramos dentro de otro collider

        if (other.CompareTag("ZonaRoja"))
        {
            Debug.Log("DENTRO: Has entrado en la Zona ROJA");
        }

        else if (other.CompareTag("ZonaAzul"))
        {
            Debug.Log("DENTRO: Has entrado en la Zona AZUL");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //para cuando salimos 

        if (other.CompareTag("ZonaRoja"))
        {
            Debug.Log("FUERA: Has salido de la Zona ROJA");
        }
        else if (other.CompareTag("ZonaAzul"))
        {
            Debug.Log("FUERA: Has salido de la Zona AZUL");
        }
    }
}

