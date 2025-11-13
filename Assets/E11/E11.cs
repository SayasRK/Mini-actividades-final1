using UnityEngine;

public class E11 : MonoBehaviour
{
    [SerializeField]
    private int jugador; // 1 = piedra, 2 = papel, 3 = tijeras

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int oponente = Random.Range(1, 4); // 1 a 3 (4 no incluido)


        //Mostrar los numeros que eligen
        Debug.Log("Jugador eligió: " + jugador);
        Debug.Log("Oponente eligió: " + oponente);


        //Comparar a ver quien gana 
        //if: Comprueba la priemra condicion 
        //Comprueba otra condicion si el fi no se cumplió 
        //Si no se cumple ninguna de las dos -> asigna un jugador 


        if (jugador == oponente)
        {
            Debug.Log("Resultado: Empate");
        }
        else if (
            (jugador == 1 && oponente == 3) ||
            (jugador == 2 && oponente == 1) ||
            (jugador == 3 && oponente == 2)
        )
        {
            Debug.Log("Resultado: Gana el jugador");
        }
        else
        {
            Debug.Log("Resultado: Gana el oponente");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
