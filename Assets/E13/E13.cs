using UnityEngine;

public class E13 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int count = 0;


        //Con este while generamos 100 nums aleatorios
        while (count < 100)
        {
            float NumeroAleatorio = Random.Range(0f, 100f);
            Debug.Log(NumeroAleatorio);
            count++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
