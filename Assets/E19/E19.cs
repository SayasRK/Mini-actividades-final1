using UnityEngine;

public class E19 : MonoBehaviour
{
    //Vel Inspector
    [SerializeField]
    private float velocidad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //El objeto no se mueve si no se pulsa ninguna tecla. 
        Vector3 direccion = new Vector3(0, 0, 0);

        //Para detectar si se estan pulsando las teclas.
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

        //Aplicamos el movimiento
        transform.position = transform.position + direccion * velocidad * Time.deltaTime;

    }
}
