using UnityEngine;

public class E35Camara : MonoBehaviour
{
    [SerializeField] private Transform objetivo;
    [SerializeField] private float velocidadMaxima = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objetivo == null) return;

        Vector3 posicionDeseada = new Vector3(objetivo.position.x, objetivo.position.y, transform.position.z);

        // movimiento suave con la maxima velocidad

        transform.position = Vector3.MoveTowards(transform.position, posicionDeseada, velocidadMaxima * Time.deltaTime);
    }
}
