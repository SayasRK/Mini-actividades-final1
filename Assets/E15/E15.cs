using UnityEngine;

public class E15 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int jugador1 = 0;
        int jugador2 = 0;

        //El juego se repite hasta que uno gane 3 veces.
        while (jugador1 < 3 && jugador2 < 3)
            
        {
            //Esto es para generara las jugadas aleatoriamente. 
            int jugada1 = Random.Range(1, 4);
            int jugada2 = Random.Range(1, 4);

      

            if (jugada1 == jugada2)
            {
                Debug.Log("Empate");
            }
            else if (
                (jugada1 == 1 && jugada2 == 3) ||
                (jugada1 == 2 && jugada2 == 1) ||
                (jugada1 == 3 && jugada2 == 2)
            )
            {
                jugador1++;
                Debug.Log("Jugador 1 gana esta ronda");
            }
            else
            {
                jugador2++;
                Debug.Log("Jugador 2 gana esta ronda");
            }


        }

        //Muestra el ganador final 
        if (jugador1 == 3)
        {
            Debug.Log("¡Jugador 1 gana el juego!");
        }
        else
        {
            Debug.Log("¡Jugador 2 gana el juego!");
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
