using UnityEngine;

public class E22 : MonoBehaviour
{
    public GameObject objetivo;
    [SerializeField] private float velocidad = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, objetivo.transform.position, velocidad * Time.deltaTime);
    }
}

//Para el movimiento del cubo A he usado el mismo script del ej anterior (el de movimiento con wasd) 
