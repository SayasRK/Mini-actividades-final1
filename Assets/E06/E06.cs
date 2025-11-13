using UnityEngine;

public class E06 : MonoBehaviour
{
    [SerializeField]
    private int numero1;

    [SerializeField]
    private int numero2;

    [SerializeField]
    private int numero3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //3f es para que Unity pueda dar resultados en numeros decimales. 
        int suma = numero1 + numero2 + numero3;
        float promedio = suma / 3f;

        Debug.Log("Promedio: " + promedio);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
