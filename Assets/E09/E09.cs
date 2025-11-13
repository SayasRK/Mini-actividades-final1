using UnityEngine;

public class E09 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Usamos "f" para que Unity entienda que son numeros decimales (float) 
        //Random.Range es para que genere un numero aleatorio con decimales.
        // Y lo ponemos en Update para que se actualice CADA FRAME.


        float numeroAleatorio = Random.Range(-10f, 10f);
        Debug.Log("Número aleatorio: " + numeroAleatorio);

    }
}
