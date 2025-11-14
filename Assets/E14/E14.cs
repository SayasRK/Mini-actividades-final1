using UnityEngine;

public class E14 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

        
    //Esto son dos bucles para hacer todas las combinaciones de las tabals de multiplicar del 1 al 10
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                int resultado = i * j;
                Debug.Log(i + " x " + j + " = " + resultado);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
