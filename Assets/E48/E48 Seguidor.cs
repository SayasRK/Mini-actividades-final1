using UnityEngine;

public class E48Seguidor : MonoBehaviour
{
    [SerializeField] private Transform objetivo;
    private float fixedY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objetivo == null) return;

        transform.position = new Vector3(
            objetivo.position.x,
            fixedY,
            transform.position.z
        );

        //El seguidor solo copia el eje X 
        //La altura se mantiene fija para que no suba ni baje
    }
}
