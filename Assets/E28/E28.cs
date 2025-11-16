using UnityEngine;

public class E28 : MonoBehaviour
{
    public float velocidad = 5f;
    private Vector3 direccion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direccion = new Vector3(0, 0, 0);

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
    }

        void FixedUpdate()
        {
            transform.position = transform.position + direccion * velocidad * Time.fixedDeltaTime;
        }
    
}

//FixedUpdate se usa para cosas que tienen fisicas (Rigidbody) 
//Así el movimiento es mas suave y no depende del rendimiento del pc

