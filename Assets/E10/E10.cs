using UnityEngine;

public class E10 : MonoBehaviour
{
    void Start()
    {
        // Genero dos números aleatorios entre -10 y 10
        float numeroA = Random.Range(-10f, 10f);
        float numeroB = Random.Range(-10f, 10f);

        // Genero un número aleatorio del 0 al 4 para elegir la operación
        int operacion = Random.Range(0, 5); // 0=+, 1=-, 2=*, 3=/, 4=%

        float resultado = 0;

        // Uso if/else para decidir qué operación hacer
        if (operacion == 0)
        {
            resultado = numeroA + numeroB;
            Debug.Log(numeroA + " + " + numeroB + " = " + resultado);
        }
        else if (operacion == 1)
        {
            resultado = numeroA - numeroB;
            Debug.Log(numeroA + " - " + numeroB + " = " + resultado);
        }
        else if (operacion == 2)
        {
            resultado = numeroA * numeroB;
            Debug.Log(numeroA + " * " + numeroB + " = " + resultado);
        }
        else if (operacion == 3)
        {
            if (numeroB != 0)
            {
                resultado = numeroA / numeroB;
                Debug.Log(numeroA + " / " + numeroB + " = " + resultado);
            }
            else
            {
                Debug.Log("No se puede dividir por cero");
            }
        }
        else if (operacion == 4)
        {
            if (numeroB != 0)
            {
                resultado = numeroA % numeroB;
                Debug.Log(numeroA + " % " + numeroB + " = " + resultado);
            }
            else
            {
                Debug.Log("No se puede hacer módulo con cero");
            }
        }
    }

    void Update()
    {

    }
}
