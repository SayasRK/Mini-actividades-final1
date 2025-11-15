using UnityEngine;

public class E18 : MonoBehaviour
{
    [SerializeField]

    //para poder cambiar la velocidad desde el inspector
    private float velocidad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento hacia arriba a la izquierda
        //movimiento con velocidad ajustable y deltaTime para ajustar

        Vector3 direccion = new Vector3(-1, 1, 0);

        transform.position = transform.position + direccion * velocidad * Time.deltaTime;
    }
}
