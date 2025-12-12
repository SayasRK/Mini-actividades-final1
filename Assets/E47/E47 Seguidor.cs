using UnityEngine;

public class E47Seguidor : MonoBehaviour
{
    [SerializeField] private Transform objetivo;
    [SerializeField] private float maxSpeed = 3f;
    [SerializeField] private float distanciaSeguimiento = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objetivo == null) return;

        float distancia = Vector2.Distance(transform.position, objetivo.position);

        if (distancia < distanciaSeguimiento)

        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                objetivo.position,
                maxSpeed * Time.deltaTime
            );

            //El objeto no lo empieza a seguir hasta que lo tiene a cinco unidades de el
        }
    }
}
