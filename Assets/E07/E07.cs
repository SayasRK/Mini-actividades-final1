using UnityEngine;

public class E07 : MonoBehaviour
{
    public float numeroA;
    public float numeroB;
    public string operacion; // elige entre + - * / %

    void Start()
    {
        float resultado = 0;

        // Hago la operación según el símbolo que pongo en el inspector
        if (operacion == "+")
        {
            resultado = numeroA + numeroB;
        }
        else if (operacion == "-")
        {
            resultado = numeroA - numeroB;
        }
        else if (operacion == "*")
        {
            resultado = numeroA * numeroB;
        }
        else if (operacion == "/")
        {
            if (numeroB != 0)
            {
                resultado = numeroA / numeroB;
            }
            else
            {
                Debug.Log("No se puede dividir por cero");
                return;
            }
        }
        else if (operacion == "%")
        {
            if (numeroB != 0)
            {
                resultado = numeroA % numeroB;
            }
            else
            {
                Debug.Log("No se puede hacer módulo con cero");
                return;
            }
        }
        else
        {
            Debug.Log("Operación no válida");
            return;
        }

        Debug.Log("Resultado: " + resultado);
    }

    void Update()
    {

    }
}
