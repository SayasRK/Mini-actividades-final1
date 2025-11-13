using UnityEngine;

public class E10 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Genera dos numeros aleatorios entre -10 y 10


        float numeroA = Random.Range(-10f, 10f);
        float numeroB = Random.Range(-10f, 10f);



        //Esto es para elegir una operación aleatoria.

        string operacion = "";

        int opcion = Random.Range(0, 5); // 0, 1, 2, 3, 4

        switch (opcion)
        {
            case 0:
                operacion = "+";
                break;
            case 1:
                operacion = "-";
                break;
            case 2:
                operacion = "*";
                break;
            case 3:
                operacion = "/";
                break;
            case 4:
                operacion = "%";
                break;
        }

        float resultado = 0f;

        switch (operacion)
        {
            case "+":
                resultado = numeroA + numeroB;
                break;

            case "-":
                resultado = numeroA - numeroB;
                break;

            case "*":
                resultado = numeroA * numeroB;
                break;

            case "/":
                if (numeroB != 0)
                {
                    resultado = numeroA / numeroB;
                }
                else
                {
                    Debug.Log("Error: División por cero.");
                    return;
                }
                break;

            case "%":
                if (numeroB != 0)
                {
                    resultado = numeroA % numeroB;
                }
                else
                {
                    Debug.Log("Error: Módulo con cero.");
                    return;
                }
                break;
        }

        Debug.Log(numeroA + " " + operacion + " " + numeroB + " = " + resultado);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
