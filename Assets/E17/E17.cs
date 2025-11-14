using UnityEngine;

public class E17 : MonoBehaviour
{
    //Es para poder cambiar desde el inspector la velocidad.

    [SerializeField]
private float velocidad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1f, -1f, 0f) * velocidad; 

    }
}
