using UnityEngine;

public class E16 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Esto hace que el objeto se mueva en diagonal hacia abajo a la derecha cada frame.

        Vector3 direccion = new Vector3(1, -1, 0);
        transform.position = transform.position + direccion;


    }
}
