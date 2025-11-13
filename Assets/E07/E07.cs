using UnityEngine;

public class E07 : MonoBehaviour
{
    [SerializeField]
    private float numeroA;

    [SerializeField]
    private float numeroB;

    [SerializeField]
    private string operacion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
                // Esto es para evitar que divida entre 0 y que salga error ya que es una operacion invalida. 

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
                // Hacemos lo mismo para que no divida por 0. 
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

            default:
                Debug.Log("Operación no válida.");
                return;
        }

        Debug.Log("Resultado: " + resultado);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
