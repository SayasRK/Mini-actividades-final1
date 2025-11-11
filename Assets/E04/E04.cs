using UnityEngine;

public class E04 : MonoBehaviour
{
    [SerializeField]
    private Vector3 vectorToPrint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Aqui solo se ejecuta una vez al iniciar el juego 
        Debug.Log("El Vector3 es: " + vectorToPrint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
