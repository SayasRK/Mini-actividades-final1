using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float numero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {

            //Este bucle va del 1 al 10 y lo que hace es calcular el resultado de multiplicar el numero i en cada vuelta.
         
            float resultado = numero * i;
            Debug.Log(numero + " x " + i + " = " + resultado);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
